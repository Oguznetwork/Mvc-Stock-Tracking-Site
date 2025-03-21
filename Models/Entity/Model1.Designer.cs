﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("MvcDbStokModel", "FK_TBLURUNLER_TBLKATEGORILER", "TBLKATEGORILER", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(MvcStok.Models.Entity.TBLKATEGORILER), "TBLURUNLER", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MvcStok.Models.Entity.TBLURUNLER), true)]
[assembly: EdmRelationshipAttribute("MvcDbStokModel", "FK_TBLSATISLAR_TBLMUSTERILER", "TBLMUSTERILER", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(MvcStok.Models.Entity.TBLMUSTERILER), "TBLSATISLAR", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MvcStok.Models.Entity.TBLSATISLAR), true)]
[assembly: EdmRelationshipAttribute("MvcDbStokModel", "FK_TBLSATISLAR_TBLURUNLER", "TBLURUNLER", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(MvcStok.Models.Entity.TBLURUNLER), "TBLSATISLAR", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MvcStok.Models.Entity.TBLSATISLAR), true)]

#endregion

namespace MvcStok.Models.Entity
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MvcDbStokEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MvcDbStokEntities object using the connection string found in the 'MvcDbStokEntities' section of the application configuration file.
        /// </summary>
        public MvcDbStokEntities() : base("name=MvcDbStokEntities", "MvcDbStokEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MvcDbStokEntities object.
        /// </summary>
        public MvcDbStokEntities(string connectionString) : base(connectionString, "MvcDbStokEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MvcDbStokEntities object.
        /// </summary>
        public MvcDbStokEntities(EntityConnection connection) : base(connection, "MvcDbStokEntities")
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
        public ObjectSet<sysdiagrams> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagrams>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagrams> _sysdiagrams;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TBLKATEGORILER> TBLKATEGORILER
        {
            get
            {
                if ((_TBLKATEGORILER == null))
                {
                    _TBLKATEGORILER = base.CreateObjectSet<TBLKATEGORILER>("TBLKATEGORILER");
                }
                return _TBLKATEGORILER;
            }
        }
        private ObjectSet<TBLKATEGORILER> _TBLKATEGORILER;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TBLMUSTERILER> TBLMUSTERILER
        {
            get
            {
                if ((_TBLMUSTERILER == null))
                {
                    _TBLMUSTERILER = base.CreateObjectSet<TBLMUSTERILER>("TBLMUSTERILER");
                }
                return _TBLMUSTERILER;
            }
        }
        private ObjectSet<TBLMUSTERILER> _TBLMUSTERILER;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TBLSATISLAR> TBLSATISLAR
        {
            get
            {
                if ((_TBLSATISLAR == null))
                {
                    _TBLSATISLAR = base.CreateObjectSet<TBLSATISLAR>("TBLSATISLAR");
                }
                return _TBLSATISLAR;
            }
        }
        private ObjectSet<TBLSATISLAR> _TBLSATISLAR;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TBLURUNLER> TBLURUNLER
        {
            get
            {
                if ((_TBLURUNLER == null))
                {
                    _TBLURUNLER = base.CreateObjectSet<TBLURUNLER>("TBLURUNLER");
                }
                return _TBLURUNLER;
            }
        }
        private ObjectSet<TBLURUNLER> _TBLURUNLER;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the sysdiagrams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosysdiagrams(sysdiagrams sysdiagrams)
        {
            base.AddObject("sysdiagrams", sysdiagrams);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TBLKATEGORILER EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTBLKATEGORILER(TBLKATEGORILER tBLKATEGORILER)
        {
            base.AddObject("TBLKATEGORILER", tBLKATEGORILER);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TBLMUSTERILER EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTBLMUSTERILER(TBLMUSTERILER tBLMUSTERILER)
        {
            base.AddObject("TBLMUSTERILER", tBLMUSTERILER);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TBLSATISLAR EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTBLSATISLAR(TBLSATISLAR tBLSATISLAR)
        {
            base.AddObject("TBLSATISLAR", tBLSATISLAR);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TBLURUNLER EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTBLURUNLER(TBLURUNLER tBLURUNLER)
        {
            base.AddObject("TBLURUNLER", tBLURUNLER);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MvcDbStokModel", Name="sysdiagrams")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagrams : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new sysdiagrams object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="principal_id">Initial value of the principal_id property.</param>
        /// <param name="diagram_id">Initial value of the diagram_id property.</param>
        public static sysdiagrams Createsysdiagrams(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagrams sysdiagrams = new sysdiagrams();
            sysdiagrams.name = name;
            sysdiagrams.principal_id = principal_id;
            sysdiagrams.diagram_id = diagram_id;
            return sysdiagrams;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false, "name");
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value, "principal_id");
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value, "diagram_id");
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value, "version");
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true, "definition");
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MvcDbStokModel", Name="TBLKATEGORILER")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TBLKATEGORILER : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TBLKATEGORILER object.
        /// </summary>
        /// <param name="kATEGORIID">Initial value of the KATEGORIID property.</param>
        public static TBLKATEGORILER CreateTBLKATEGORILER(global::System.Int16 kATEGORIID)
        {
            TBLKATEGORILER tBLKATEGORILER = new TBLKATEGORILER();
            tBLKATEGORILER.KATEGORIID = kATEGORIID;
            return tBLKATEGORILER;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 KATEGORIID
        {
            get
            {
                return _KATEGORIID;
            }
            set
            {
                if (_KATEGORIID != value)
                {
                    OnKATEGORIIDChanging(value);
                    ReportPropertyChanging("KATEGORIID");
                    _KATEGORIID = StructuralObject.SetValidValue(value, "KATEGORIID");
                    ReportPropertyChanged("KATEGORIID");
                    OnKATEGORIIDChanged();
                }
            }
        }
        private global::System.Int16 _KATEGORIID;
        partial void OnKATEGORIIDChanging(global::System.Int16 value);
        partial void OnKATEGORIIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String KATEGORIAD
        {
            get
            {
                return _KATEGORIAD;
            }
            set
            {
                OnKATEGORIADChanging(value);
                ReportPropertyChanging("KATEGORIAD");
                _KATEGORIAD = StructuralObject.SetValidValue(value, true, "KATEGORIAD");
                ReportPropertyChanged("KATEGORIAD");
                OnKATEGORIADChanged();
            }
        }
        private global::System.String _KATEGORIAD;
        partial void OnKATEGORIADChanging(global::System.String value);
        partial void OnKATEGORIADChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MvcDbStokModel", "FK_TBLURUNLER_TBLKATEGORILER", "TBLURUNLER")]
        public EntityCollection<TBLURUNLER> TBLURUNLER
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TBLURUNLER>("MvcDbStokModel.FK_TBLURUNLER_TBLKATEGORILER", "TBLURUNLER");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TBLURUNLER>("MvcDbStokModel.FK_TBLURUNLER_TBLKATEGORILER", "TBLURUNLER", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MvcDbStokModel", Name="TBLMUSTERILER")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TBLMUSTERILER : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TBLMUSTERILER object.
        /// </summary>
        /// <param name="mUSTERIID">Initial value of the MUSTERIID property.</param>
        public static TBLMUSTERILER CreateTBLMUSTERILER(global::System.Int32 mUSTERIID)
        {
            TBLMUSTERILER tBLMUSTERILER = new TBLMUSTERILER();
            tBLMUSTERILER.MUSTERIID = mUSTERIID;
            return tBLMUSTERILER;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MUSTERIID
        {
            get
            {
                return _MUSTERIID;
            }
            set
            {
                if (_MUSTERIID != value)
                {
                    OnMUSTERIIDChanging(value);
                    ReportPropertyChanging("MUSTERIID");
                    _MUSTERIID = StructuralObject.SetValidValue(value, "MUSTERIID");
                    ReportPropertyChanged("MUSTERIID");
                    OnMUSTERIIDChanged();
                }
            }
        }
        private global::System.Int32 _MUSTERIID;
        partial void OnMUSTERIIDChanging(global::System.Int32 value);
        partial void OnMUSTERIIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MUSTERIAD
        {
            get
            {
                return _MUSTERIAD;
            }
            set
            {
                OnMUSTERIADChanging(value);
                ReportPropertyChanging("MUSTERIAD");
                _MUSTERIAD = StructuralObject.SetValidValue(value, true, "MUSTERIAD");
                ReportPropertyChanged("MUSTERIAD");
                OnMUSTERIADChanged();
            }
        }
        private global::System.String _MUSTERIAD;
        partial void OnMUSTERIADChanging(global::System.String value);
        partial void OnMUSTERIADChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MUSTERISOYAD
        {
            get
            {
                return _MUSTERISOYAD;
            }
            set
            {
                OnMUSTERISOYADChanging(value);
                ReportPropertyChanging("MUSTERISOYAD");
                _MUSTERISOYAD = StructuralObject.SetValidValue(value, true, "MUSTERISOYAD");
                ReportPropertyChanged("MUSTERISOYAD");
                OnMUSTERISOYADChanged();
            }
        }
        private global::System.String _MUSTERISOYAD;
        partial void OnMUSTERISOYADChanging(global::System.String value);
        partial void OnMUSTERISOYADChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MvcDbStokModel", "FK_TBLSATISLAR_TBLMUSTERILER", "TBLSATISLAR")]
        public EntityCollection<TBLSATISLAR> TBLSATISLAR
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TBLSATISLAR>("MvcDbStokModel.FK_TBLSATISLAR_TBLMUSTERILER", "TBLSATISLAR");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TBLSATISLAR>("MvcDbStokModel.FK_TBLSATISLAR_TBLMUSTERILER", "TBLSATISLAR", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MvcDbStokModel", Name="TBLSATISLAR")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TBLSATISLAR : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TBLSATISLAR object.
        /// </summary>
        /// <param name="sATISID">Initial value of the SATISID property.</param>
        public static TBLSATISLAR CreateTBLSATISLAR(global::System.Int32 sATISID)
        {
            TBLSATISLAR tBLSATISLAR = new TBLSATISLAR();
            tBLSATISLAR.SATISID = sATISID;
            return tBLSATISLAR;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SATISID
        {
            get
            {
                return _SATISID;
            }
            set
            {
                if (_SATISID != value)
                {
                    OnSATISIDChanging(value);
                    ReportPropertyChanging("SATISID");
                    _SATISID = StructuralObject.SetValidValue(value, "SATISID");
                    ReportPropertyChanged("SATISID");
                    OnSATISIDChanged();
                }
            }
        }
        private global::System.Int32 _SATISID;
        partial void OnSATISIDChanging(global::System.Int32 value);
        partial void OnSATISIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> URUN
        {
            get
            {
                return _URUN;
            }
            set
            {
                OnURUNChanging(value);
                ReportPropertyChanging("URUN");
                _URUN = StructuralObject.SetValidValue(value, "URUN");
                ReportPropertyChanged("URUN");
                OnURUNChanged();
            }
        }
        private Nullable<global::System.Int32> _URUN;
        partial void OnURUNChanging(Nullable<global::System.Int32> value);
        partial void OnURUNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> MUSTERI
        {
            get
            {
                return _MUSTERI;
            }
            set
            {
                OnMUSTERIChanging(value);
                ReportPropertyChanging("MUSTERI");
                _MUSTERI = StructuralObject.SetValidValue(value, "MUSTERI");
                ReportPropertyChanged("MUSTERI");
                OnMUSTERIChanged();
            }
        }
        private Nullable<global::System.Int32> _MUSTERI;
        partial void OnMUSTERIChanging(Nullable<global::System.Int32> value);
        partial void OnMUSTERIChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Byte> ADET
        {
            get
            {
                return _ADET;
            }
            set
            {
                OnADETChanging(value);
                ReportPropertyChanging("ADET");
                _ADET = StructuralObject.SetValidValue(value, "ADET");
                ReportPropertyChanged("ADET");
                OnADETChanged();
            }
        }
        private Nullable<global::System.Byte> _ADET;
        partial void OnADETChanging(Nullable<global::System.Byte> value);
        partial void OnADETChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> FIYAT
        {
            get
            {
                return _FIYAT;
            }
            set
            {
                OnFIYATChanging(value);
                ReportPropertyChanging("FIYAT");
                _FIYAT = StructuralObject.SetValidValue(value, "FIYAT");
                ReportPropertyChanged("FIYAT");
                OnFIYATChanged();
            }
        }
        private Nullable<global::System.Decimal> _FIYAT;
        partial void OnFIYATChanging(Nullable<global::System.Decimal> value);
        partial void OnFIYATChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MvcDbStokModel", "FK_TBLSATISLAR_TBLMUSTERILER", "TBLMUSTERILER")]
        public TBLMUSTERILER TBLMUSTERILER
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLMUSTERILER>("MvcDbStokModel.FK_TBLSATISLAR_TBLMUSTERILER", "TBLMUSTERILER").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLMUSTERILER>("MvcDbStokModel.FK_TBLSATISLAR_TBLMUSTERILER", "TBLMUSTERILER").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TBLMUSTERILER> TBLMUSTERILERReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLMUSTERILER>("MvcDbStokModel.FK_TBLSATISLAR_TBLMUSTERILER", "TBLMUSTERILER");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TBLMUSTERILER>("MvcDbStokModel.FK_TBLSATISLAR_TBLMUSTERILER", "TBLMUSTERILER", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MvcDbStokModel", "FK_TBLSATISLAR_TBLURUNLER", "TBLURUNLER")]
        public TBLURUNLER TBLURUNLER
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLURUNLER>("MvcDbStokModel.FK_TBLSATISLAR_TBLURUNLER", "TBLURUNLER").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLURUNLER>("MvcDbStokModel.FK_TBLSATISLAR_TBLURUNLER", "TBLURUNLER").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TBLURUNLER> TBLURUNLERReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLURUNLER>("MvcDbStokModel.FK_TBLSATISLAR_TBLURUNLER", "TBLURUNLER");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TBLURUNLER>("MvcDbStokModel.FK_TBLSATISLAR_TBLURUNLER", "TBLURUNLER", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MvcDbStokModel", Name="TBLURUNLER")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TBLURUNLER : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TBLURUNLER object.
        /// </summary>
        /// <param name="uRUNID">Initial value of the URUNID property.</param>
        public static TBLURUNLER CreateTBLURUNLER(global::System.Int32 uRUNID)
        {
            TBLURUNLER tBLURUNLER = new TBLURUNLER();
            tBLURUNLER.URUNID = uRUNID;
            return tBLURUNLER;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 URUNID
        {
            get
            {
                return _URUNID;
            }
            set
            {
                if (_URUNID != value)
                {
                    OnURUNIDChanging(value);
                    ReportPropertyChanging("URUNID");
                    _URUNID = StructuralObject.SetValidValue(value, "URUNID");
                    ReportPropertyChanged("URUNID");
                    OnURUNIDChanged();
                }
            }
        }
        private global::System.Int32 _URUNID;
        partial void OnURUNIDChanging(global::System.Int32 value);
        partial void OnURUNIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String URUNAD
        {
            get
            {
                return _URUNAD;
            }
            set
            {
                OnURUNADChanging(value);
                ReportPropertyChanging("URUNAD");
                _URUNAD = StructuralObject.SetValidValue(value, true, "URUNAD");
                ReportPropertyChanged("URUNAD");
                OnURUNADChanged();
            }
        }
        private global::System.String _URUNAD;
        partial void OnURUNADChanging(global::System.String value);
        partial void OnURUNADChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> URUNKATEGORI
        {
            get
            {
                return _URUNKATEGORI;
            }
            set
            {
                OnURUNKATEGORIChanging(value);
                ReportPropertyChanging("URUNKATEGORI");
                _URUNKATEGORI = StructuralObject.SetValidValue(value, "URUNKATEGORI");
                ReportPropertyChanged("URUNKATEGORI");
                OnURUNKATEGORIChanged();
            }
        }
        private Nullable<global::System.Int16> _URUNKATEGORI;
        partial void OnURUNKATEGORIChanging(Nullable<global::System.Int16> value);
        partial void OnURUNKATEGORIChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> FIYAT
        {
            get
            {
                return _FIYAT;
            }
            set
            {
                OnFIYATChanging(value);
                ReportPropertyChanging("FIYAT");
                _FIYAT = StructuralObject.SetValidValue(value, "FIYAT");
                ReportPropertyChanged("FIYAT");
                OnFIYATChanged();
            }
        }
        private Nullable<global::System.Decimal> _FIYAT;
        partial void OnFIYATChanging(Nullable<global::System.Decimal> value);
        partial void OnFIYATChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MvcDbStokModel", "FK_TBLURUNLER_TBLKATEGORILER", "TBLKATEGORILER")]
        public TBLKATEGORILER TBLKATEGORILER
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLKATEGORILER>("MvcDbStokModel.FK_TBLURUNLER_TBLKATEGORILER", "TBLKATEGORILER").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLKATEGORILER>("MvcDbStokModel.FK_TBLURUNLER_TBLKATEGORILER", "TBLKATEGORILER").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<TBLKATEGORILER> TBLKATEGORILERReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<TBLKATEGORILER>("MvcDbStokModel.FK_TBLURUNLER_TBLKATEGORILER", "TBLKATEGORILER");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<TBLKATEGORILER>("MvcDbStokModel.FK_TBLURUNLER_TBLKATEGORILER", "TBLKATEGORILER", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MvcDbStokModel", "FK_TBLSATISLAR_TBLURUNLER", "TBLSATISLAR")]
        public EntityCollection<TBLSATISLAR> TBLSATISLAR
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<TBLSATISLAR>("MvcDbStokModel.FK_TBLSATISLAR_TBLURUNLER", "TBLSATISLAR");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<TBLSATISLAR>("MvcDbStokModel.FK_TBLSATISLAR_TBLURUNLER", "TBLSATISLAR", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
