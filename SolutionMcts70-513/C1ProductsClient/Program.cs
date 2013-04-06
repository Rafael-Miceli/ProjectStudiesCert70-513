using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ProductsClient.ProductsService;
using System.Threading;
using System.Security.Principal;

namespace C1ProductsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            //Create a proxy object and connect to the service
            PermissiveCertificatePolicy.Enact("CN=rafapri");
            ProductsServiceClient proxy = new ProductsServiceClient("WS2007HttpBinding_IProductsService_Chapter5EndPoint");

            /*
            proxy.ClientCredentials.Windows.ClientCredential.Domain = "mss-rj-210";
            proxy.ClientCredentials.Windows.ClientCredential.UserName = "Fred";
            proxy.ClientCredentials.Windows.ClientCredential.Password = "teste";
            */
            
            proxy.ClientCredentials.UserName.UserName = "bert";//WindowsIdentity.GetCurrent().Name;//"mss\\rafael.paiva";
            proxy.ClientCredentials.UserName.Password = @"Pa$$w0rd";//"1709Raf@prielscill@";
            //ProductsServiceClient proxy = new ProductsServiceClient();

            // Test the operations in the service
            try
            {
                // Obtain a list of all products
                Console.WriteLine("Test 1: List all products");
                string[] productNumbers = proxy.ListProducts();
                foreach (string productNumber in productNumbers)
                {
                    Console.WriteLine("Number: {0}", productNumber);
                }
                Console.WriteLine();


                Console.WriteLine("Test 2: Display the details of a product");
                ProductData product = proxy.GetProduct("WB-H098");
                Console.WriteLine("Number: {0}", product.ProductNumber);
                Console.WriteLine("Name: {0}", product.Name);
                Console.WriteLine("Color: {0}", product.Color);
                Console.WriteLine("Price: {0}", product.ListPrice);
                Console.WriteLine();


                // Query the stock level of this product
                Console.WriteLine("Test 3: Display the stock level of a product");
                int numInStock = proxy.CurrentStockLevel("WB-H098");
                Console.WriteLine("Current stock level: {0}", numInStock);
                Console.WriteLine();


                // Modify the stock level of this product
                Console.WriteLine("Test 4: Modify the stock level of a product");
                if (proxy.ChangeStockLevel("WB-H098", 100, "N/A", 0))
                {
                    numInStock = proxy.CurrentStockLevel("WB-H098");
                    Console.WriteLine("Stock changed. Current stock level: {0}", numInStock);
                }
                else
                {
                    Console.WriteLine("Stock level update failed");
                }
                Console.WriteLine();
            }
            catch (FaultException<SystemFault> sf)
            {
                Console.WriteLine("SystemFault {0}: {1}\n{2}",
                sf.Detail.SystemOperation, sf.Detail.SystemMessage,
                sf.Detail.SystemReason);
            }
            catch (FaultException<DatabaseFault> dbf)
            {
                Console.WriteLine("DatabaseFault {0}: {1}\n{2}",
                dbf.Detail.DbOperation, dbf.Detail.DbMessage,
                dbf.Detail.DbReason);
            }
            catch (FaultException e)
            {
                Console.WriteLine("{0}: {1}", e.Code.Name, e.Reason);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception: {0}", ex.Message);
            }

            proxy.Close();
            Console.WriteLine("Press ENTER to finish");

            Console.ReadKey();
        }
    }

    class PermissiveCertificatePolicy
    {
        string subjectName;
        static PermissiveCertificatePolicy currentPolicy;

        PermissiveCertificatePolicy(string subjectName)
        {
            this.subjectName = subjectName;
            ServicePointManager.ServerCertificateValidationCallback +=
            new System.Net.Security.RemoteCertificateValidationCallback
            (RemoteCertValidate);
        }

        public static void Enact(string subjectName)
        {
            currentPolicy = new PermissiveCertificatePolicy(subjectName);
        }

        bool RemoteCertValidate(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error)
        {
            if(cert.Subject == subjectName)
            {
                return true;
            }
            return false;
        }
    }
}
