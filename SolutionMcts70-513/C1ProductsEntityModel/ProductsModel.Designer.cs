﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("AdventureWorks2008R2_DataModel", "FK_ProductInventory_Product_ProductID", "Product", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(C1ProductsEntityModel.Product), "ProductInventory", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(C1ProductsEntityModel.ProductInventory), true)]

#endregion

namespace C1ProductsEntityModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AdventureWorks2008R2_DataEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AdventureWorks2008R2_DataEntities object using the connection string found in the 'AdventureWorks2008R2_DataEntities' section of the application configuration file.
        /// </summary>
        public AdventureWorks2008R2_DataEntities() : base("name=AdventureWorks2008R2_DataEntities", "AdventureWorks2008R2_DataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureWorks2008R2_DataEntities object.
        /// </summary>
        public AdventureWorks2008R2_DataEntities(string connectionString) : base(connectionString, "AdventureWorks2008R2_DataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureWorks2008R2_DataEntities object.
        /// </summary>
        public AdventureWorks2008R2_DataEntities(EntityConnection connection) : base(connection, "AdventureWorks2008R2_DataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Product
        {
            get
            {
                if ((_Product == null))
                {
                    _Product = base.CreateObjectSet<Product>("Product");
                }
                return _Product;
            }
        }
        private ObjectSet<Product> _Product;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ProductInventory> ProductInventory
        {
            get
            {
                if ((_ProductInventory == null))
                {
                    _ProductInventory = base.CreateObjectSet<ProductInventory>("ProductInventory");
                }
                return _ProductInventory;
            }
        }
        private ObjectSet<ProductInventory> _ProductInventory;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Product EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProduct(Product product)
        {
            base.AddObject("Product", product);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ProductInventory EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProductInventory(ProductInventory productInventory)
        {
            base.AddObject("ProductInventory", productInventory);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorks2008R2_DataModel", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="productID">Initial value of the ProductID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="productNumber">Initial value of the ProductNumber property.</param>
        /// <param name="makeFlag">Initial value of the MakeFlag property.</param>
        /// <param name="finishedGoodsFlag">Initial value of the FinishedGoodsFlag property.</param>
        /// <param name="safetyStockLevel">Initial value of the SafetyStockLevel property.</param>
        /// <param name="reorderPoint">Initial value of the ReorderPoint property.</param>
        /// <param name="standardCost">Initial value of the StandardCost property.</param>
        /// <param name="listPrice">Initial value of the ListPrice property.</param>
        /// <param name="daysToManufacture">Initial value of the DaysToManufacture property.</param>
        /// <param name="sellStartDate">Initial value of the SellStartDate property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Product CreateProduct(global::System.Int32 productID, global::System.String name, global::System.String productNumber, global::System.Boolean makeFlag, global::System.Boolean finishedGoodsFlag, global::System.Int16 safetyStockLevel, global::System.Int16 reorderPoint, global::System.Decimal standardCost, global::System.Decimal listPrice, global::System.Int32 daysToManufacture, global::System.DateTime sellStartDate, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Product product = new Product();
            product.ProductID = productID;
            product.Name = name;
            product.ProductNumber = productNumber;
            product.MakeFlag = makeFlag;
            product.FinishedGoodsFlag = finishedGoodsFlag;
            product.SafetyStockLevel = safetyStockLevel;
            product.ReorderPoint = reorderPoint;
            product.StandardCost = standardCost;
            product.ListPrice = listPrice;
            product.DaysToManufacture = daysToManufacture;
            product.SellStartDate = sellStartDate;
            product.rowguid = rowguid;
            product.ModifiedDate = modifiedDate;
            return product;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                if (_ProductID != value)
                {
                    OnProductIDChanging(value);
                    ReportPropertyChanging("ProductID");
                    _ProductID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductID");
                    OnProductIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductID;
        partial void OnProductIDChanging(global::System.Int32 value);
        partial void OnProductIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProductNumber
        {
            get
            {
                return _ProductNumber;
            }
            set
            {
                OnProductNumberChanging(value);
                ReportPropertyChanging("ProductNumber");
                _ProductNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProductNumber");
                OnProductNumberChanged();
            }
        }
        private global::System.String _ProductNumber;
        partial void OnProductNumberChanging(global::System.String value);
        partial void OnProductNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean MakeFlag
        {
            get
            {
                return _MakeFlag;
            }
            set
            {
                OnMakeFlagChanging(value);
                ReportPropertyChanging("MakeFlag");
                _MakeFlag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MakeFlag");
                OnMakeFlagChanged();
            }
        }
        private global::System.Boolean _MakeFlag;
        partial void OnMakeFlagChanging(global::System.Boolean value);
        partial void OnMakeFlagChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean FinishedGoodsFlag
        {
            get
            {
                return _FinishedGoodsFlag;
            }
            set
            {
                OnFinishedGoodsFlagChanging(value);
                ReportPropertyChanging("FinishedGoodsFlag");
                _FinishedGoodsFlag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FinishedGoodsFlag");
                OnFinishedGoodsFlagChanged();
            }
        }
        private global::System.Boolean _FinishedGoodsFlag;
        partial void OnFinishedGoodsFlagChanging(global::System.Boolean value);
        partial void OnFinishedGoodsFlagChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Color
        {
            get
            {
                return _Color;
            }
            set
            {
                OnColorChanging(value);
                ReportPropertyChanging("Color");
                _Color = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Color");
                OnColorChanged();
            }
        }
        private global::System.String _Color;
        partial void OnColorChanging(global::System.String value);
        partial void OnColorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 SafetyStockLevel
        {
            get
            {
                return _SafetyStockLevel;
            }
            set
            {
                OnSafetyStockLevelChanging(value);
                ReportPropertyChanging("SafetyStockLevel");
                _SafetyStockLevel = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SafetyStockLevel");
                OnSafetyStockLevelChanged();
            }
        }
        private global::System.Int16 _SafetyStockLevel;
        partial void OnSafetyStockLevelChanging(global::System.Int16 value);
        partial void OnSafetyStockLevelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 ReorderPoint
        {
            get
            {
                return _ReorderPoint;
            }
            set
            {
                OnReorderPointChanging(value);
                ReportPropertyChanging("ReorderPoint");
                _ReorderPoint = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ReorderPoint");
                OnReorderPointChanged();
            }
        }
        private global::System.Int16 _ReorderPoint;
        partial void OnReorderPointChanging(global::System.Int16 value);
        partial void OnReorderPointChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal StandardCost
        {
            get
            {
                return _StandardCost;
            }
            set
            {
                OnStandardCostChanging(value);
                ReportPropertyChanging("StandardCost");
                _StandardCost = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StandardCost");
                OnStandardCostChanged();
            }
        }
        private global::System.Decimal _StandardCost;
        partial void OnStandardCostChanging(global::System.Decimal value);
        partial void OnStandardCostChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal ListPrice
        {
            get
            {
                return _ListPrice;
            }
            set
            {
                OnListPriceChanging(value);
                ReportPropertyChanging("ListPrice");
                _ListPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ListPrice");
                OnListPriceChanged();
            }
        }
        private global::System.Decimal _ListPrice;
        partial void OnListPriceChanging(global::System.Decimal value);
        partial void OnListPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Size
        {
            get
            {
                return _Size;
            }
            set
            {
                OnSizeChanging(value);
                ReportPropertyChanging("Size");
                _Size = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Size");
                OnSizeChanged();
            }
        }
        private global::System.String _Size;
        partial void OnSizeChanging(global::System.String value);
        partial void OnSizeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SizeUnitMeasureCode
        {
            get
            {
                return _SizeUnitMeasureCode;
            }
            set
            {
                OnSizeUnitMeasureCodeChanging(value);
                ReportPropertyChanging("SizeUnitMeasureCode");
                _SizeUnitMeasureCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SizeUnitMeasureCode");
                OnSizeUnitMeasureCodeChanged();
            }
        }
        private global::System.String _SizeUnitMeasureCode;
        partial void OnSizeUnitMeasureCodeChanging(global::System.String value);
        partial void OnSizeUnitMeasureCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String WeightUnitMeasureCode
        {
            get
            {
                return _WeightUnitMeasureCode;
            }
            set
            {
                OnWeightUnitMeasureCodeChanging(value);
                ReportPropertyChanging("WeightUnitMeasureCode");
                _WeightUnitMeasureCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("WeightUnitMeasureCode");
                OnWeightUnitMeasureCodeChanged();
            }
        }
        private global::System.String _WeightUnitMeasureCode;
        partial void OnWeightUnitMeasureCodeChanging(global::System.String value);
        partial void OnWeightUnitMeasureCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                OnWeightChanging(value);
                ReportPropertyChanging("Weight");
                _Weight = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Weight");
                OnWeightChanged();
            }
        }
        private Nullable<global::System.Decimal> _Weight;
        partial void OnWeightChanging(Nullable<global::System.Decimal> value);
        partial void OnWeightChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DaysToManufacture
        {
            get
            {
                return _DaysToManufacture;
            }
            set
            {
                OnDaysToManufactureChanging(value);
                ReportPropertyChanging("DaysToManufacture");
                _DaysToManufacture = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DaysToManufacture");
                OnDaysToManufactureChanged();
            }
        }
        private global::System.Int32 _DaysToManufacture;
        partial void OnDaysToManufactureChanging(global::System.Int32 value);
        partial void OnDaysToManufactureChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ProductLine
        {
            get
            {
                return _ProductLine;
            }
            set
            {
                OnProductLineChanging(value);
                ReportPropertyChanging("ProductLine");
                _ProductLine = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ProductLine");
                OnProductLineChanged();
            }
        }
        private global::System.String _ProductLine;
        partial void OnProductLineChanging(global::System.String value);
        partial void OnProductLineChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Class
        {
            get
            {
                return _Class;
            }
            set
            {
                OnClassChanging(value);
                ReportPropertyChanging("Class");
                _Class = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Class");
                OnClassChanged();
            }
        }
        private global::System.String _Class;
        partial void OnClassChanging(global::System.String value);
        partial void OnClassChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Style
        {
            get
            {
                return _Style;
            }
            set
            {
                OnStyleChanging(value);
                ReportPropertyChanging("Style");
                _Style = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Style");
                OnStyleChanged();
            }
        }
        private global::System.String _Style;
        partial void OnStyleChanging(global::System.String value);
        partial void OnStyleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ProductSubcategoryID
        {
            get
            {
                return _ProductSubcategoryID;
            }
            set
            {
                OnProductSubcategoryIDChanging(value);
                ReportPropertyChanging("ProductSubcategoryID");
                _ProductSubcategoryID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProductSubcategoryID");
                OnProductSubcategoryIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ProductSubcategoryID;
        partial void OnProductSubcategoryIDChanging(Nullable<global::System.Int32> value);
        partial void OnProductSubcategoryIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ProductModelID
        {
            get
            {
                return _ProductModelID;
            }
            set
            {
                OnProductModelIDChanging(value);
                ReportPropertyChanging("ProductModelID");
                _ProductModelID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProductModelID");
                OnProductModelIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ProductModelID;
        partial void OnProductModelIDChanging(Nullable<global::System.Int32> value);
        partial void OnProductModelIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime SellStartDate
        {
            get
            {
                return _SellStartDate;
            }
            set
            {
                OnSellStartDateChanging(value);
                ReportPropertyChanging("SellStartDate");
                _SellStartDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SellStartDate");
                OnSellStartDateChanged();
            }
        }
        private global::System.DateTime _SellStartDate;
        partial void OnSellStartDateChanging(global::System.DateTime value);
        partial void OnSellStartDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> SellEndDate
        {
            get
            {
                return _SellEndDate;
            }
            set
            {
                OnSellEndDateChanging(value);
                ReportPropertyChanging("SellEndDate");
                _SellEndDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SellEndDate");
                OnSellEndDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _SellEndDate;
        partial void OnSellEndDateChanging(Nullable<global::System.DateTime> value);
        partial void OnSellEndDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DiscontinuedDate
        {
            get
            {
                return _DiscontinuedDate;
            }
            set
            {
                OnDiscontinuedDateChanging(value);
                ReportPropertyChanging("DiscontinuedDate");
                _DiscontinuedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DiscontinuedDate");
                OnDiscontinuedDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _DiscontinuedDate;
        partial void OnDiscontinuedDateChanging(Nullable<global::System.DateTime> value);
        partial void OnDiscontinuedDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorks2008R2_DataModel", "FK_ProductInventory_Product_ProductID", "ProductInventory")]
        public EntityCollection<ProductInventory> ProductInventory
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ProductInventory>("AdventureWorks2008R2_DataModel.FK_ProductInventory_Product_ProductID", "ProductInventory");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ProductInventory>("AdventureWorks2008R2_DataModel.FK_ProductInventory_Product_ProductID", "ProductInventory", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorks2008R2_DataModel", Name="ProductInventory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ProductInventory : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ProductInventory object.
        /// </summary>
        /// <param name="productID">Initial value of the ProductID property.</param>
        /// <param name="locationID">Initial value of the LocationID property.</param>
        /// <param name="shelf">Initial value of the Shelf property.</param>
        /// <param name="bin">Initial value of the Bin property.</param>
        /// <param name="quantity">Initial value of the Quantity property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static ProductInventory CreateProductInventory(global::System.Int32 productID, global::System.Int16 locationID, global::System.String shelf, global::System.Byte bin, global::System.Int16 quantity, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            ProductInventory productInventory = new ProductInventory();
            productInventory.ProductID = productID;
            productInventory.LocationID = locationID;
            productInventory.Shelf = shelf;
            productInventory.Bin = bin;
            productInventory.Quantity = quantity;
            productInventory.rowguid = rowguid;
            productInventory.ModifiedDate = modifiedDate;
            return productInventory;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                if (_ProductID != value)
                {
                    OnProductIDChanging(value);
                    ReportPropertyChanging("ProductID");
                    _ProductID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductID");
                    OnProductIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductID;
        partial void OnProductIDChanging(global::System.Int32 value);
        partial void OnProductIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 LocationID
        {
            get
            {
                return _LocationID;
            }
            set
            {
                if (_LocationID != value)
                {
                    OnLocationIDChanging(value);
                    ReportPropertyChanging("LocationID");
                    _LocationID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("LocationID");
                    OnLocationIDChanged();
                }
            }
        }
        private global::System.Int16 _LocationID;
        partial void OnLocationIDChanging(global::System.Int16 value);
        partial void OnLocationIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Shelf
        {
            get
            {
                return _Shelf;
            }
            set
            {
                OnShelfChanging(value);
                ReportPropertyChanging("Shelf");
                _Shelf = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Shelf");
                OnShelfChanged();
            }
        }
        private global::System.String _Shelf;
        partial void OnShelfChanging(global::System.String value);
        partial void OnShelfChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte Bin
        {
            get
            {
                return _Bin;
            }
            set
            {
                OnBinChanging(value);
                ReportPropertyChanging("Bin");
                _Bin = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Bin");
                OnBinChanged();
            }
        }
        private global::System.Byte _Bin;
        partial void OnBinChanging(global::System.Byte value);
        partial void OnBinChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                OnQuantityChanging(value);
                ReportPropertyChanging("Quantity");
                _Quantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Quantity");
                OnQuantityChanged();
            }
        }
        private global::System.Int16 _Quantity;
        partial void OnQuantityChanging(global::System.Int16 value);
        partial void OnQuantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorks2008R2_DataModel", "FK_ProductInventory_Product_ProductID", "Product")]
        public Product Product
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("AdventureWorks2008R2_DataModel.FK_ProductInventory_Product_ProductID", "Product").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("AdventureWorks2008R2_DataModel.FK_ProductInventory_Product_ProductID", "Product").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Product> ProductReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("AdventureWorks2008R2_DataModel.FK_ProductInventory_Product_ProductID", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Product>("AdventureWorks2008R2_DataModel.FK_ProductInventory_Product_ProductID", "Product", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
