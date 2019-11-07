
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization


<Assembly: EdmSchemaAttribute("cd282e25-bcc9-4f67-9e79-fbff578f4ac8")>
#Region "EDM Relationship Metadata"
<Assembly: EdmRelationshipAttribute("LightSwitchApplication", "FK_Product_ProductRebate", "Product", System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(PrescriptionContoso.Implementation.Product), "ProductRebate", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(PrescriptionContoso.Implementation.ProductRebate), True)>

#End Region

Namespace PrescriptionContoso.Implementation

    #Region "Contexts"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public Partial Class PrescriptionContosoObjectContext
        Inherits ObjectContext
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new PrescriptionContosoObjectContext object using the connection string found in the 'PrescriptionContosoObjectContext' section of the application configuration file.
        ''' </summary>
        Public Sub New()
            MyBase.New("name=PrescriptionContosoObjectContext", "PrescriptionContosoObjectContext")
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new PrescriptionContosoObjectContext object.
        ''' </summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "PrescriptionContosoObjectContext")
            OnContextCreated()
        End Sub
    
        ''' <summary>
        ''' Initialize a new PrescriptionContosoObjectContext object.
        ''' </summary>
        Public Sub New(ByVal connection As EntityConnection)
            MyBase.New(connection, "PrescriptionContosoObjectContext")
            OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "Partial Methods"
    
        Partial Private Sub OnContextCreated()
        End Sub
    
        #End Region
    
        #Region "ObjectSet Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property Products() As ObjectSet(Of Product)
            Get
                If (_Products Is Nothing) Then
                    _Products = MyBase.CreateObjectSet(Of Product)("Products")
                End If
                Return _Products
            End Get
        End Property
    
        Private _Products As ObjectSet(Of Product)
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        Public ReadOnly Property ProductRebates() As ObjectSet(Of ProductRebate)
            Get
                If (_ProductRebates Is Nothing) Then
                    _ProductRebates = MyBase.CreateObjectSet(Of ProductRebate)("ProductRebates")
                End If
                Return _ProductRebates
            End Get
        End Property
    
        Private _ProductRebates As ObjectSet(Of ProductRebate)

        #End Region

        #Region "AddTo Methods"
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToProducts(ByVal product As Product)
            MyBase.AddObject("Products", product)
        End Sub
    
        ''' <summary>
        ''' Deprecated Method for adding a new object to the ProductRebates EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
        ''' </summary>
        Public Sub AddToProductRebates(ByVal productRebate As ProductRebate)
            MyBase.AddObject("ProductRebates", productRebate)
        End Sub

        #End Region

    End Class

    #End Region

    #Region "Entities"
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="LightSwitchApplication", Name:="Product")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class Product
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new Product object.
        ''' </summary>
        ''' <param name="productID">Initial value of the ProductID property.</param>
        ''' <param name="productName">Initial value of the ProductName property.</param>
        ''' <param name="mSRP">Initial value of the MSRP property.</param>
        Public Shared Function CreateProduct(productID As Global.System.Int32, productName As Global.System.String, mSRP As Global.System.Decimal) As Product
            Dim product as Product = New Product
            product.ProductID = productID
            product.ProductName = productName
            product.MSRP = mSRP
            Return product
        End Function

        #End Region

        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property ProductID() As Global.System.Int32
            Get
                Return _ProductID
            End Get
            Set
                If (_ProductID <> Value) Then
                    OnProductIDChanging(value)
                    ReportPropertyChanging("ProductID")
                    _ProductID = value
                    ReportPropertyChanged("ProductID")
                    OnProductIDChanged()
                End If
            End Set
        End Property
    
        Private _ProductID As Global.System.Int32
        Private Partial Sub OnProductIDChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnProductIDChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property ProductName() As Global.System.String
            Get
                Return _ProductName
            End Get
            Set
                OnProductNameChanging(value)
                ReportPropertyChanging("ProductName")
                _ProductName = value
                ReportPropertyChanged("ProductName")
                OnProductNameChanged()
            End Set
        End Property
    
        Private _ProductName As Global.System.String
        Private Partial Sub OnProductNameChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnProductNameChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property MSRP() As Global.System.Decimal
            Get
                Return _MSRP
            End Get
            Set
                OnMSRPChanging(value)
                ReportPropertyChanging("MSRP")
                _MSRP = value
                ReportPropertyChanged("MSRP")
                OnMSRPChanged()
            End Set
        End Property
    
        Private _MSRP As Global.System.Decimal
        Private Partial Sub OnMSRPChanging(value As Global.System.Decimal)
        End Sub
    
        Private Partial Sub OnMSRPChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Description() As Global.System.String
            Get
                Return _Description
            End Get
            Set
                OnDescriptionChanging(value)
                ReportPropertyChanging("Description")
                _Description = value
                ReportPropertyChanged("Description")
                OnDescriptionChanged()
            End Set
        End Property
    
        Private _Description As Global.System.String
        Private Partial Sub OnDescriptionChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnDescriptionChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property ProductImage() As Global.System.Byte()
            Get
                    Return StructuralObject.GetValidValue(_ProductImage)
            End Get
            Set
                OnProductImageChanging(value)
                ReportPropertyChanging("ProductImage")
                _ProductImage = value
                ReportPropertyChanged("ProductImage")
                OnProductImageChanged()
            End Set
        End Property
    
        Private _ProductImage As Global.System.Byte()
        Private Partial Sub OnProductImageChanging(value As Global.System.Byte())
        End Sub
    
        Private Partial Sub OnProductImageChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Category() As Global.System.String
            Get
                Return _Category
            End Get
            Set
                OnCategoryChanging(value)
                ReportPropertyChanging("Category")
                _Category = value
                ReportPropertyChanged("Category")
                OnCategoryChanged()
            End Set
        End Property
    
        Private _Category As Global.System.String
        Private Partial Sub OnCategoryChanging(value As Global.System.String)
        End Sub
    
        Private Partial Sub OnCategoryChanged()
        End Sub

        #End Region

        #Region "Navigation Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <XmlIgnoreAttribute()>
        <SoapIgnoreAttribute()>
        <DataMemberAttribute()>
        <EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Product_ProductRebate", "ProductRebate")>
         Public Property ProductRebates() As EntityCollection(Of ProductRebate)
            Get
                Return CType(Me,IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of ProductRebate)("LightSwitchApplication.FK_Product_ProductRebate", "ProductRebate")
            End Get
            Set
                If (Not value Is Nothing)
                    CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedCollection(Of ProductRebate)("LightSwitchApplication.FK_Product_ProductRebate", "ProductRebate", value)
                End If
            End Set
        End Property

        #End Region

    End Class
    
    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmEntityTypeAttribute(NamespaceName:="LightSwitchApplication", Name:="ProductRebate")>
    <Serializable()>
    <DataContractAttribute(IsReference:=True)>
    Public Partial Class ProductRebate
        Inherits EntityObject
        #Region "Factory Method"
    
        ''' <summary>
        ''' Create a new ProductRebate object.
        ''' </summary>
        ''' <param name="productRebateID">Initial value of the ProductRebateID property.</param>
        ''' <param name="productID">Initial value of the ProductID property.</param>
        Public Shared Function CreateProductRebate(productRebateID As Global.System.Int32, productID As Global.System.Int32) As ProductRebate
            Dim productRebate as ProductRebate = New ProductRebate
            productRebate.ProductRebateID = productRebateID
            productRebate.ProductID = productID
            Return productRebate
        End Function

        #End Region

        #Region "Primitive Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property ProductRebateID() As Global.System.Int32
            Get
                Return _ProductRebateID
            End Get
            Set
                If (_ProductRebateID <> Value) Then
                    OnProductRebateIDChanging(value)
                    ReportPropertyChanging("ProductRebateID")
                    _ProductRebateID = value
                    ReportPropertyChanged("ProductRebateID")
                    OnProductRebateIDChanged()
                End If
            End Set
        End Property
    
        Private _ProductRebateID As Global.System.Int32
        Private Partial Sub OnProductRebateIDChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnProductRebateIDChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property RebateStart() As Nullable(Of Global.System.DateTime)
            Get
                Return _RebateStart
            End Get
            Set
                OnRebateStartChanging(value)
                ReportPropertyChanging("RebateStart")
                _RebateStart = value
                ReportPropertyChanged("RebateStart")
                OnRebateStartChanged()
            End Set
        End Property
    
        Private _RebateStart As Nullable(Of Global.System.DateTime)
        Private Partial Sub OnRebateStartChanging(value As Nullable(Of Global.System.DateTime))
        End Sub
    
        Private Partial Sub OnRebateStartChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property RebateEnd() As Nullable(Of Global.System.DateTime)
            Get
                Return _RebateEnd
            End Get
            Set
                OnRebateEndChanging(value)
                ReportPropertyChanging("RebateEnd")
                _RebateEnd = value
                ReportPropertyChanged("RebateEnd")
                OnRebateEndChanged()
            End Set
        End Property
    
        Private _RebateEnd As Nullable(Of Global.System.DateTime)
        Private Partial Sub OnRebateEndChanging(value As Nullable(Of Global.System.DateTime))
        End Sub
    
        Private Partial Sub OnRebateEndChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
        <DataMemberAttribute()>
        Public Property Rebate() As Nullable(Of Global.System.Decimal)
            Get
                Return _Rebate
            End Get
            Set
                OnRebateChanging(value)
                ReportPropertyChanging("Rebate")
                _Rebate = value
                ReportPropertyChanged("Rebate")
                OnRebateChanged()
            End Set
        End Property
    
        Private _Rebate As Nullable(Of Global.System.Decimal)
        Private Partial Sub OnRebateChanging(value As Nullable(Of Global.System.Decimal))
        End Sub
    
        Private Partial Sub OnRebateChanged()
        End Sub
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=false)>
        <DataMemberAttribute()>
        Public Property ProductID() As Global.System.Int32
            Get
                Return _ProductID
            End Get
            Set
                OnProductIDChanging(value)
                ReportPropertyChanging("ProductID")
                _ProductID = value
                ReportPropertyChanged("ProductID")
                OnProductIDChanged()
            End Set
        End Property
    
        Private _ProductID As Global.System.Int32
        Private Partial Sub OnProductIDChanging(value As Global.System.Int32)
        End Sub
    
        Private Partial Sub OnProductIDChanged()
        End Sub

        #End Region

        #Region "Navigation Properties"
    
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <XmlIgnoreAttribute()>
        <SoapIgnoreAttribute()>
        <DataMemberAttribute()>
        <EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Product_ProductRebate", "Product")>
        Public Property Product() As Product
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Product)("LightSwitchApplication.FK_Product_ProductRebate", "Product").Value
            End Get
            Set
                CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Product)("LightSwitchApplication.FK_Product_ProductRebate", "Product").Value = value
            End Set
        End Property
        ''' <summary>
        ''' No Metadata Documentation available.
        ''' </summary>
        <BrowsableAttribute(False)>
        <DataMemberAttribute()>
        Public Property ProductReference() As EntityReference(Of Product)
            Get
                Return CType(Me, IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Product)("LightSwitchApplication.FK_Product_ProductRebate", "Product")
            End Get
            Set
                If (Not value Is Nothing)
                    CType(Me, IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Product)("LightSwitchApplication.FK_Product_ProductRebate", "Product", value)
                End If
            End Set
        End Property

        #End Region

    End Class

    #End Region

    
End Namespace
