using System;
using System.Security;
using System.Security.Principal;
using System.Security.Permissions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C1ProductsEntityModel;
using System.ServiceModel;
using System.Threading;
using System.Windows;

namespace ProductsServiceLibrary
{
    public class ProductsServiceImpl :IProductsService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "WarehouseStaff")]
        public List<string> ListProducts()
        {
            //string userName = Thread.CurrentPrincipal.Identity.Name;

            //MessageBox.Show(string.Format("Username is {0}", userName), "ProductsService Authentication", MessageBoxButton.OK);
            // Create a list for holding product numbers            
            List<string> productsList = new List<string>();
            try
            {
                // Connect to the AdventureWorks database by using the Entity Framework
                using(AdventureWorks2008R2_DataEntities database = new AdventureWorks2008R2_DataEntities())
                {
                    //database.Connection.Open();
                    // Fetch the product number of every product in the database
                    var products = from product in database.Product
                                   select product.ProductNumber;
                    productsList = products.ToList();
                }
            }
            catch(Exception ex)
            {
                // Edit the Initial Catalog in the connection string in app.config
                // to trigger this exception
                if (ex.InnerException is System.Data.SqlClient.SqlException)
                {
                    //throw new FaultException(
                    //"Exception accessing database: " +
                    //ex.InnerException.Message, new FaultCode("Connect to database"));

                    DatabaseFault dbf = new DatabaseFault
                    {
                        DbOperation = "Connect to database",
                        DbReason = "Exception accessing database",
                        DbMessage = ex.InnerException.Message
                    };
                    throw new FaultException<DatabaseFault>(dbf);
                }
                else
                {
                    //throw new FaultException(
                    //"Exception reading product numbers: " +
                    //ex.Message, new FaultCode("Iterate through products"));

                    SystemFault dbf = new SystemFault
                    {
                        SystemOperation = "Iterate through products",
                        SystemReason = "Exception reading product numbers",
                        SystemMessage = ex.Message
                    };
                    throw new FaultException<SystemFault>(dbf);
                }
            }
            // Return the list of product numbers
            return productsList;
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "WarehouseStaff")]
        public ProductData GetProduct(string productNumber)
        {
            // Create a reference to a ProductData object
            // This object will be instantiated if a matching product is found
            ProductData productData = null;
            try
            {
                // Connect to the AdventureWorks database by using the Entity Framework
                using(AdventureWorks2008R2_DataEntities database = new AdventureWorks2008R2_DataEntities())
                {
                    //database.Connection.Open();
                    // Find the first product that matches the specified product number
                    Product matchingProduct = database.Product.First(
                    p => String.Compare(p.ProductNumber, productNumber) == 0);
                    productData = new ProductData()
                    {
                        Name = matchingProduct.Name,
                        ProductNumber = matchingProduct.ProductNumber,
                        Color = matchingProduct.Color,
                        ListPrice = matchingProduct.ListPrice
                    };
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the product
            return productData;
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "WarehouseStaff")]
        public int CurrentStockLevel(string productNumber)
        {
            // Obtain the total stock level for the specified product.
            // The stock level is calculated by summing the quantity of the product
            // available in all the bins in the ProductInventory table.
            // The Product and ProductInventory tables are joined over the
            // ProductID column.
            int stockLevel = 0;
            try
            {
                // Connect to the AdventureWorks database by using the Entity Framework
                using(AdventureWorks2008R2_DataEntities database = new AdventureWorks2008R2_DataEntities())
                {
                    //database.Connection.Open();
                    // Calculate the sum of all quantities for the specified product
                    stockLevel = (from pi in database.ProductInventory
                                  join p in database.Product
                                  on pi.ProductID equals p.ProductID
                                  where String.Compare(p.ProductNumber, productNumber) == 0
                                  select (int)pi.Quantity).Sum();
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the stock level
            return stockLevel;
        }

        public bool ChangeStockLevel(string productNumber, short newStockLevel, string shelf, int bin)
        {
            // Determine whether the user is a member of the StockControllers role

            WindowsPrincipal user = new WindowsPrincipal((WindowsIdentity)Thread.CurrentPrincipal.Identity);

            if (!user.IsInRole("StockControllers"))
            {
                throw new SecurityException("Access denied");
            }

            // Modify the current stock level of the selected product
            // in the ProductInventory table.
            // If the update is successful then return true, otherwise return false.
            // The Product and ProductInventory tables are joined over the
            // ProductID column.
            try
            {
                // Connect to the AdventureWorks database by using the Entity Framework
                using(AdventureWorks2008R2_DataEntities database = new AdventureWorks2008R2_DataEntities())
                {
                    //database.Connection.Open();
                    // Find the ProductID for the specified product
                    int productID =
                    (from p in database.Product
                     where String.Compare(p.ProductNumber, productNumber) == 0
                     select p.ProductID).First();
                    // Find the ProductInventory object that matches the parameters passed
                    // in to the operation
                    ProductInventory productInventory = database.ProductInventory.First(
                    pi => String.Compare(pi.Shelf, shelf) == 0 &&
                    pi.Bin == bin &&
                    pi.ProductID == productID);
                    // Update the stock level for the ProductInventory object
                    productInventory.Quantity += newStockLevel;
                    // Save the change back to the database
                    database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }

            // Return true to indicate success
            return true;
        }
    }
}
