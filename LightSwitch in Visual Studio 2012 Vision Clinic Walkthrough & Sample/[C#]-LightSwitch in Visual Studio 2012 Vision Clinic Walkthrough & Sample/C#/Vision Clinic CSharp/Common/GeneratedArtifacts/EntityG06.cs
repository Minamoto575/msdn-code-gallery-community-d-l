

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class ProductRebate : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the ProductRebate entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ProductRebate()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ProductRebate(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.ProductRebate> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.ProductRebate.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ProductRebate_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ProductRebate_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int ProductRebateID
        {
            get
            {
                return global::LightSwitchApplication.ProductRebate.DetailsClass.GetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.ProductRebateID);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ProductRebateID_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ProductRebateID_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ProductRebateID_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<global::System.DateTime> RebateStart
        {
            get
            {
                return global::LightSwitchApplication.ProductRebate.DetailsClass.GetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.RebateStart);
            }
            set
            {
                global::LightSwitchApplication.ProductRebate.DetailsClass.SetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.RebateStart, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RebateStart_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RebateStart_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RebateStart_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<global::System.DateTime> RebateEnd
        {
            get
            {
                return global::LightSwitchApplication.ProductRebate.DetailsClass.GetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.RebateEnd);
            }
            set
            {
                global::LightSwitchApplication.ProductRebate.DetailsClass.SetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.RebateEnd, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RebateEnd_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RebateEnd_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RebateEnd_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<decimal> Rebate
        {
            get
            {
                return global::LightSwitchApplication.ProductRebate.DetailsClass.GetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Rebate);
            }
            set
            {
                global::LightSwitchApplication.ProductRebate.DetailsClass.SetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Rebate, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Rebate_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Rebate_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Rebate_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Product Product
        {
            get
            {
                return global::LightSwitchApplication.ProductRebate.DetailsClass.GetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Product);
            }
            set
            {
                global::LightSwitchApplication.ProductRebate.DetailsClass.SetValue(this, global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Product, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Product_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Product_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Product_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.ProductRebate,
                global::LightSwitchApplication.ProductRebate.DetailsClass,
                global::LightSwitchApplication.ProductRebate.DetailsClass.IImplementation,
                global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.ProductRebateID;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass>.Entry
                __ProductRebateEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass>.Entry(
                    global::LightSwitchApplication.ProductRebate.DetailsClass.__ProductRebate_CreateNew,
                    global::LightSwitchApplication.ProductRebate.DetailsClass.__ProductRebate_Created,
                    global::LightSwitchApplication.ProductRebate.DetailsClass.__ProductRebate_AllowSaveWithErrors);
            private static global::LightSwitchApplication.ProductRebate __ProductRebate_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.ProductRebate> es)
            {
                return new global::LightSwitchApplication.ProductRebate(es);
            }
            private static void __ProductRebate_Created(global::LightSwitchApplication.ProductRebate e)
            {
                e.ProductRebate_Created();
            }
            private static bool __ProductRebate_AllowSaveWithErrors(global::LightSwitchApplication.ProductRebate e)
            {
                bool result = false;
                e.ProductRebate_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, int> ProductRebateID
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.ProductRebateID) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>> RebateStart
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.RebateStart) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>> RebateEnd
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.RebateEnd) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<decimal>> Rebate
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Rebate) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<decimal>>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::LightSwitchApplication.Product> Product
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Product) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::LightSwitchApplication.Product>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int ProductRebateID { get; }
                new global::System.Nullable<global::System.DateTime> RebateStart { get; set; }
                new global::System.Nullable<global::System.DateTime> RebateEnd { get; set; }
                new global::System.Nullable<decimal> Rebate { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Product { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, int>.Entry
                    ProductRebateID = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, int>.Entry(
                        "ProductRebateID",
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._ProductRebateID_Stub,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._ProductRebateID_ComputeIsReadOnly,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._ProductRebateID_Validate,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._ProductRebateID_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._ProductRebateID_OnValueChanged);
                private static void _ProductRebateID_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ProductRebate.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, int>.Data> c, global::LightSwitchApplication.ProductRebate.DetailsClass d, object sf)
                {
                    c(d, ref d._ProductRebateID, sf);
                }
                private static bool _ProductRebateID_ComputeIsReadOnly(global::LightSwitchApplication.ProductRebate e)
                {
                    bool result = false;
                    e.ProductRebateID_IsReadOnly(ref result);
                    return result;
                }
                private static void _ProductRebateID_Validate(global::LightSwitchApplication.ProductRebate e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.ProductRebateID_Validate(r);
                }
                private static int _ProductRebateID_GetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d)
                {
                    return d.ImplementationEntity.ProductRebateID;
                }
                private static void _ProductRebateID_OnValueChanged(global::LightSwitchApplication.ProductRebate e)
                {
                    e.ProductRebateID_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry
                    RebateStart = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry(
                        "RebateStart",
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateStart_Stub,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateStart_ComputeIsReadOnly,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateStart_Validate,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateStart_GetImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateStart_SetImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateStart_OnValueChanged);
                private static void _RebateStart_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ProductRebate.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data> c, global::LightSwitchApplication.ProductRebate.DetailsClass d, object sf)
                {
                    c(d, ref d._RebateStart, sf);
                }
                private static bool _RebateStart_ComputeIsReadOnly(global::LightSwitchApplication.ProductRebate e)
                {
                    bool result = false;
                    e.RebateStart_IsReadOnly(ref result);
                    return result;
                }
                private static void _RebateStart_Validate(global::LightSwitchApplication.ProductRebate e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RebateStart_Validate(r);
                }
                private static global::System.Nullable<global::System.DateTime> _RebateStart_GetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d)
                {
                    return d.ImplementationEntity.RebateStart;
                }
                private static void _RebateStart_SetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d, global::System.Nullable<global::System.DateTime> v)
                {
                    d.ImplementationEntity.RebateStart = global::LightSwitchApplication.ProductRebate.DetailsClass.ClearDateTimeKind(v);
                }
                private static void _RebateStart_OnValueChanged(global::LightSwitchApplication.ProductRebate e)
                {
                    e.RebateStart_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry
                    RebateEnd = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>.Entry(
                        "RebateEnd",
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateEnd_Stub,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateEnd_ComputeIsReadOnly,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateEnd_Validate,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateEnd_GetImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateEnd_SetImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._RebateEnd_OnValueChanged);
                private static void _RebateEnd_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ProductRebate.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data> c, global::LightSwitchApplication.ProductRebate.DetailsClass d, object sf)
                {
                    c(d, ref d._RebateEnd, sf);
                }
                private static bool _RebateEnd_ComputeIsReadOnly(global::LightSwitchApplication.ProductRebate e)
                {
                    bool result = false;
                    e.RebateEnd_IsReadOnly(ref result);
                    return result;
                }
                private static void _RebateEnd_Validate(global::LightSwitchApplication.ProductRebate e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RebateEnd_Validate(r);
                }
                private static global::System.Nullable<global::System.DateTime> _RebateEnd_GetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d)
                {
                    return d.ImplementationEntity.RebateEnd;
                }
                private static void _RebateEnd_SetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d, global::System.Nullable<global::System.DateTime> v)
                {
                    d.ImplementationEntity.RebateEnd = global::LightSwitchApplication.ProductRebate.DetailsClass.ClearDateTimeKind(v);
                }
                private static void _RebateEnd_OnValueChanged(global::LightSwitchApplication.ProductRebate e)
                {
                    e.RebateEnd_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<decimal>>.Entry
                    Rebate = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<decimal>>.Entry(
                        "Rebate",
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Rebate_Stub,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Rebate_ComputeIsReadOnly,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Rebate_Validate,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Rebate_GetImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Rebate_SetImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Rebate_OnValueChanged);
                private static void _Rebate_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ProductRebate.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<decimal>>.Data> c, global::LightSwitchApplication.ProductRebate.DetailsClass d, object sf)
                {
                    c(d, ref d._Rebate, sf);
                }
                private static bool _Rebate_ComputeIsReadOnly(global::LightSwitchApplication.ProductRebate e)
                {
                    bool result = false;
                    e.Rebate_IsReadOnly(ref result);
                    return result;
                }
                private static void _Rebate_Validate(global::LightSwitchApplication.ProductRebate e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Rebate_Validate(r);
                }
                private static global::System.Nullable<decimal> _Rebate_GetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d)
                {
                    return d.ImplementationEntity.Rebate;
                }
                private static void _Rebate_SetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d, global::System.Nullable<decimal> v)
                {
                    d.ImplementationEntity.Rebate = v;
                }
                private static void _Rebate_OnValueChanged(global::LightSwitchApplication.ProductRebate e)
                {
                    e.Rebate_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::LightSwitchApplication.Product>.Entry
                    Product = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::LightSwitchApplication.Product>.Entry(
                        "Product",
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Product_Stub,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Product_ComputeIsReadOnly,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Product_Validate,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Product_GetCoreImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Product_GetImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Product_SetImplementationValue,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Product_Refresh,
                        global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties._Product_OnValueChanged);
                private static void _Product_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ProductRebate.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::LightSwitchApplication.Product>.Data> c, global::LightSwitchApplication.ProductRebate.DetailsClass d, object sf)
                {
                    c(d, ref d._Product, sf);
                }
                private static bool _Product_ComputeIsReadOnly(global::LightSwitchApplication.ProductRebate e)
                {
                    bool result = false;
                    e.Product_IsReadOnly(ref result);
                    return result;
                }
                private static void _Product_Validate(global::LightSwitchApplication.ProductRebate e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Product_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Product_GetCoreImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d)
                {
                    return d.ImplementationEntity.Product;
                }
                private static global::LightSwitchApplication.Product _Product_GetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Product, global::LightSwitchApplication.Product.DetailsClass>(global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Product, ref d._Product);
                }
                private static void _Product_SetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass d, global::LightSwitchApplication.Product v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Product, ref d._Product, (i, ev) => i.Product = ev, v);
                }
                private static void _Product_Refresh(global::LightSwitchApplication.ProductRebate.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.ProductRebate.DetailsClass.PropertySetProperties.Product, ref d._Product);
                }
                private static void _Product_OnValueChanged(global::LightSwitchApplication.ProductRebate e)
                {
                    e.Product_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, int>.Data _ProductRebateID;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data _RebateStart;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<global::System.DateTime>>.Data _RebateEnd;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::System.Nullable<decimal>>.Data _Rebate;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.ProductRebate, global::LightSwitchApplication.ProductRebate.DetailsClass, global::LightSwitchApplication.Product>.Data _Product;
            
        }
    
        #endregion
    }
    
    #endregion
}