﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports __State = LightSwitchApplication.State

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class State
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __State, __State.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the State entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __State))
            MyBase.New(entitySet)
            
            __State.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub State_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub State_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return Global.LightSwitchApplication.Application.Current
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(Me.Details.EntitySet.Details.DataService.Details.DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
    
        #Region "Public Properties"
    
        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Id As Integer
            Get
                Return __State.DetailsClass.GetValue(Me, __State.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __State.DetailsClass.SetValue(Me, __State.DetailsClass.PropertySetProperties.Id, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property RowVersion As Byte()
            Get
                Return __State.DetailsClass.GetValue(Me, __State.DetailsClass.PropertySetProperties.RowVersion)
            End Get
            Set
                __State.DetailsClass.SetValue(Me, __State.DetailsClass.PropertySetProperties.RowVersion, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Name As String
            Get
                Return __State.DetailsClass.GetValue(Me, __State.DetailsClass.PropertySetProperties.Name)
            End Get
            Set
                __State.DetailsClass.SetValue(Me, __State.DetailsClass.PropertySetProperties.Name, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Name_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Name_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Name_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Abbreviation As String
            Get
                Return __State.DetailsClass.GetValue(Me, __State.DetailsClass.PropertySetProperties.Abbreviation)
            End Get
            Set
                __State.DetailsClass.SetValue(Me, __State.DetailsClass.PropertySetProperties.Abbreviation, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Abbreviation_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Abbreviation_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Abbreviation_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property Customers As Global.Microsoft.LightSwitch.Framework.EntityCollection(Of Global.LightSwitchApplication.Customer)
            Get
                Return __State.DetailsClass.GetValue(Me, __State.DetailsClass.PropertySetProperties.Customers)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property CustomersQuery As Microsoft.LightSwitch.IDataServiceQueryable(Of Global.LightSwitchApplication.Customer)
            Get
                Return __State.DetailsClass.GetQuery(Me, __State.DetailsClass.PropertySetProperties.Customers)
            End Get
        End Property

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property Appointments As Global.Microsoft.LightSwitch.Framework.EntityCollection(Of Global.LightSwitchApplication.Appointment)
            Get
                Return __State.DetailsClass.GetValue(Me, __State.DetailsClass.PropertySetProperties.Appointments)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property AppointmentsQuery As Microsoft.LightSwitch.IDataServiceQueryable(Of Global.LightSwitchApplication.Appointment)
            Get
                Return __State.DetailsClass.GetQuery(Me, __State.DetailsClass.PropertySetProperties.Appointments)
            End Get
        End Property

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __State, _
                __State.DetailsClass, _
                __State.DetailsClass.IImplementation, _
                __State.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __State, __State.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __State, __State.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __State.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __StateEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __State, __State.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __State, __State.DetailsClass).Entry( _
                    AddressOf __State.DetailsClass.__State_CreateNew, _
                    AddressOf __State.DetailsClass.__State_Created, _
                    AddressOf __State.DetailsClass.__State_AllowSaveWithErrors)
            Private Shared Function __State_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __State)) As __State
                Return New __State(es)
            End Function
            Private Shared Sub __State_Created(e As __State)
                e.State_Created()
            End Sub
            Private Shared Function __State_AllowSaveWithErrors(e As __State) As Boolean
                Dim result As Boolean = False
                e.State_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __State, __State.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __State, __State.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __State.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __State, __State.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__State.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__State.DetailsClass.PropertySetProperties.RowVersion),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property Name As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__State.DetailsClass.PropertySetProperties.Name),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Abbreviation As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__State.DetailsClass.PropertySetProperties.Abbreviation),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Customers As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Customer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__State.DetailsClass.PropertySetProperties.Customers),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Customer))
                    End Get
                End Property
                
                Public ReadOnly Property Appointments As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Appointment)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__State.DetailsClass.PropertySetProperties.Appointments),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Appointment))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property RowVersion As Byte()
                Shadows Property Name As String
                Shadows Property Abbreviation As String
                Shadows ReadOnly Property Customers As Global.System.Collections.IEnumerable
                Shadows ReadOnly Property Appointments As Global.System.Collections.IEnumerable
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __State.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __State.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Integer).Data), d As __State.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __State) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __State, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __State.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __State.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __State)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Byte()).Entry( _
                        "RowVersion", _
                        AddressOf __State.DetailsClass.PropertySetProperties._RowVersion_Stub, _
                        AddressOf __State.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly, _
                        AddressOf __State.DetailsClass.PropertySetProperties._RowVersion_Validate, _
                        AddressOf __State.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue, _
                        AddressOf __State.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue, _
                        AddressOf __State.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged)
                Private Shared Sub _RowVersion_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __State.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Byte()).Data), d As __State.DetailsClass, sf As Object)
                    c(d, d._RowVersion, sf)
                End Sub
                Private Shared Function _RowVersion_ComputeIsReadOnly(e As __State) As Boolean
                    Dim result As Boolean = False
                    e.RowVersion_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RowVersion_Validate(e As __State, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RowVersion_Validate(r)
                End Sub
                Private Shared Function _RowVersion_GetImplementationValue(d As __State.DetailsClass) As Byte()
                    Return d.ImplementationEntity.RowVersion
                End Function
                Private Shared Sub _RowVersion_SetImplementationValue(d As __State.DetailsClass, v As Byte())
                    d.ImplementationEntity.RowVersion = v
                End Sub
                Private Shared Sub _RowVersion_OnValueChanged(e As __State)
                    e.RowVersion_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Name As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String).Entry( _
                        "Name", _
                        AddressOf __State.DetailsClass.PropertySetProperties._Name_Stub, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Name_ComputeIsReadOnly, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Name_Validate, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Name_GetImplementationValue, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Name_SetImplementationValue, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Name_OnValueChanged)
                Private Shared Sub _Name_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __State.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String).Data), d As __State.DetailsClass, sf As Object)
                    c(d, d._Name, sf)
                End Sub
                Private Shared Function _Name_ComputeIsReadOnly(e As __State) As Boolean
                    Dim result As Boolean = False
                    e.Name_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Name_Validate(e As __State, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Name_Validate(r)
                End Sub
                Private Shared Function _Name_GetImplementationValue(d As __State.DetailsClass) As String
                    Return d.ImplementationEntity.Name
                End Function
                Private Shared Sub _Name_SetImplementationValue(d As __State.DetailsClass, v As String)
                    d.ImplementationEntity.Name = v
                End Sub
                Private Shared Sub _Name_OnValueChanged(e As __State)
                    e.Name_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Abbreviation As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String).Entry( _
                        "Abbreviation", _
                        AddressOf __State.DetailsClass.PropertySetProperties._Abbreviation_Stub, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Abbreviation_ComputeIsReadOnly, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Abbreviation_Validate, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Abbreviation_GetImplementationValue, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Abbreviation_SetImplementationValue, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Abbreviation_OnValueChanged)
                Private Shared Sub _Abbreviation_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __State.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String).Data), d As __State.DetailsClass, sf As Object)
                    c(d, d._Abbreviation, sf)
                End Sub
                Private Shared Function _Abbreviation_ComputeIsReadOnly(e As __State) As Boolean
                    Dim result As Boolean = False
                    e.Abbreviation_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Abbreviation_Validate(e As __State, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Abbreviation_Validate(r)
                End Sub
                Private Shared Function _Abbreviation_GetImplementationValue(d As __State.DetailsClass) As String
                    Return d.ImplementationEntity.Abbreviation
                End Function
                Private Shared Sub _Abbreviation_SetImplementationValue(d As __State.DetailsClass, v As String)
                    d.ImplementationEntity.Abbreviation = v
                End Sub
                Private Shared Sub _Abbreviation_OnValueChanged(e As __State)
                    e.Abbreviation_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Customers As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Customer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Customer).Entry( _
                        "Customers", _
                        AddressOf __State.DetailsClass.PropertySetProperties._Customers_Stub, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Customers_GetReferencedEntities, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Customers_GetEntityCollection)
                Private Shared Sub _Customers_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __State.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Customer).Data), d As __State.DetailsClass, sf As Object)
                    c(d, d._Customers, sf)
                End Sub
                Private Shared Function _Customers_GetReferencedEntities(d As __State.DetailsClass) As Global.System.Collections.Generic.IEnumerable(Of Global.LightSwitchApplication.Customer)
                    Return d.GetReferencedEntities(Of Global.LightSwitchApplication.Customer, Global.LightSwitchApplication.Customer.DetailsClass)(__State.DetailsClass.PropertySetProperties.Customers, d._Customers)
                End Function
                Private Shared Function _Customers_GetEntityCollection(d As __State.DetailsClass) As Global.System.Collections.IEnumerable
                    Return d.ImplementationEntity.Customers
                End Function
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Appointments As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Appointment).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Appointment).Entry( _
                        "Appointments", _
                        AddressOf __State.DetailsClass.PropertySetProperties._Appointments_Stub, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Appointments_GetReferencedEntities, _
                        AddressOf __State.DetailsClass.PropertySetProperties._Appointments_GetEntityCollection)
                Private Shared Sub _Appointments_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __State.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Appointment).Data), d As __State.DetailsClass, sf As Object)
                    c(d, d._Appointments, sf)
                End Sub
                Private Shared Function _Appointments_GetReferencedEntities(d As __State.DetailsClass) As Global.System.Collections.Generic.IEnumerable(Of Global.LightSwitchApplication.Appointment)
                    Return d.GetReferencedEntities(Of Global.LightSwitchApplication.Appointment, Global.LightSwitchApplication.Appointment.DetailsClass)(__State.DetailsClass.PropertySetProperties.Appointments, d._Appointments)
                End Function
                Private Shared Function _Appointments_GetEntityCollection(d As __State.DetailsClass) As Global.System.Collections.IEnumerable
                    Return d.ImplementationEntity.Appointments
                End Function
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Name As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Abbreviation As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __State, __State.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Customers As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Customer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Appointments As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __State, __State.DetailsClass, Global.LightSwitchApplication.Appointment).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
