﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 24.10.2019 22:09:53
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace testContext
{

    [DatabaseAttribute(Name = "test")]
    [ProviderAttribute(typeof(Devart.Data.PostgreSql.Linq.Provider.PgSqlDataProvider))]
    public partial class testDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(testDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void Insertcities(cities instance);
        partial void Updatecities(cities instance);
        partial void Deletecities(cities instance);
        partial void Insertusers(users instance);
        partial void Updateusers(users instance);
        partial void Deleteusers(users instance);

        #endregion

        public testDataContext() :
        base(@"User Id=postgres;Host=localhost;Database=test", mappingSource)
        {
            OnCreated();
        }

        public testDataContext(MappingSource mappingSource) :
        base(@"User Id=postgres;Host=localhost;Database=test", mappingSource)
        {
            OnCreated();
        }

        public testDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public testDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public testDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public testDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<cities> cities
        {
            get
            {
                return this.GetTable<cities>();
            }
        }

        public Devart.Data.Linq.Table<users> users
        {
            get
            {
                return this.GetTable<users>();
            }
        }
    }
}

namespace testContext
{

    /// <summary>
    /// There are no comments for testContext.cities in the schema.
    /// </summary>
    [Table(Name = @"public.cities")]
    public partial class cities : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _id;

        private string _name;
        #pragma warning restore 0649
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        #endregion

        public cities()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for id in the schema.
        /// </summary>
        [Column(Storage = "_id", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "", IsDbGenerated = true, IsPrimaryKey = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id != value)
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging("id");
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for name in the schema.
        /// </summary>
        [Column(Name = @"""name""", Storage = "_name", CanBeNull = false, DbType = "VARCHAR NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (this._name != value)
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging("name");
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for testContext.users in the schema.
    /// </summary>
    [Table(Name = @"public.users")]
    public partial class users : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _id;

        private string _name;

        private int _age;

        private int _cityid;
        #pragma warning restore 0649
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnageChanging(int value);
        partial void OnageChanged();
        partial void OncityidChanging(int value);
        partial void OncityidChanged();
        #endregion

        public users()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for id in the schema.
        /// </summary>
        [Column(Storage = "_id", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "", IsDbGenerated = true, IsPrimaryKey = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id != value)
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging("id");
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for name in the schema.
        /// </summary>
        [Column(Name = @"""name""", Storage = "_name", CanBeNull = false, DbType = "VARCHAR NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (this._name != value)
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging("name");
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for age in the schema.
        /// </summary>
        [Column(Storage = "_age", CanBeNull = false, DbType = "INT4 NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int age
        {
            get
            {
                return this._age;
            }
            set
            {
                if (this._age != value)
                {
                    this.OnageChanging(value);
                    this.SendPropertyChanging("age");
                    this._age = value;
                    this.SendPropertyChanged("age");
                    this.OnageChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for cityid in the schema.
        /// </summary>
        [Column(Name = @"city_id", Storage = "_cityid", CanBeNull = false, DbType = "INT4 NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int cityid
        {
            get
            {
                return this._cityid;
            }
            set
            {
                if (this._cityid != value)
                {
                    this.OncityidChanging(value);
                    this.SendPropertyChanging("cityid");
                    this._cityid = value;
                    this.SendPropertyChanged("cityid");
                    this.OncityidChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
