﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.ApplicationData>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.ApplicationData>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Client> Query1(global::System.Nullable<int> SexId)
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Client> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.Client>("ClientSet"),
                (c) => (SexId.HasValue && (c.IdSex.Id == SexId)));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Settlement> Query2(global::System.Nullable<int> IdRoomType)
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Settlement> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.Settlement>("SettlementSet"),
                (s) => (IdRoomType.HasValue && (s.IdRoom.RoomType.Id == IdRoomType)));
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Room))
            {
                return new global::LightSwitchApplication.Implementation.Room();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Client))
            {
                return new global::LightSwitchApplication.Implementation.Client();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Settlement))
            {
                return new global::LightSwitchApplication.Implementation.Settlement();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Sex))
            {
                return new global::LightSwitchApplication.Implementation.Sex();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.RoomType))
            {
                return new global::LightSwitchApplication.Implementation.RoomType();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.ApplicationData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.ApplicationData(this.GetEntityConnectionString(
                "_IntrinsicData",
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Room))
            {
                return new global::LightSwitchApplication.Implementation.Room();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Client))
            {
                return new global::LightSwitchApplication.Implementation.Client();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Settlement))
            {
                return new global::LightSwitchApplication.Implementation.Settlement();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Sex))
            {
                return new global::LightSwitchApplication.Implementation.Sex();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.RoomType))
            {
                return new global::LightSwitchApplication.Implementation.RoomType();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Room) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Room);
            }
            if (typeof(global::LightSwitchApplication.Client) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Client);
            }
            if (typeof(global::LightSwitchApplication.Settlement) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Settlement);
            }
            if (typeof(global::LightSwitchApplication.Sex) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Sex);
            }
            if (typeof(global::LightSwitchApplication.RoomType) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.RoomType);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Room :
        global::LightSwitchApplication.Room.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Room.DetailsClass.IImplementation.RoomType
        {
            get
            {
                return this.RoomType;
            }
            set
            {
                this.RoomType = (global::LightSwitchApplication.Implementation.RoomType)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("RoomType");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Room.DetailsClass.IImplementation.SettlementCollection
        {
            get
            {
                return this.SettlementCollection;
            }
        }
        
        partial void OnRoom_RoomTypeChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("RoomType");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Client :
        global::LightSwitchApplication.Client.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Client.DetailsClass.IImplementation.IdSex
        {
            get
            {
                return this.IdSex;
            }
            set
            {
                this.IdSex = (global::LightSwitchApplication.Implementation.Sex)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("IdSex");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Client.DetailsClass.IImplementation.SettlementCollection
        {
            get
            {
                return this.SettlementCollection;
            }
        }
        
        partial void OnClient_SexChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("IdSex");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Settlement :
        global::LightSwitchApplication.Settlement.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Settlement.DetailsClass.IImplementation.IdClient
        {
            get
            {
                return this.IdClient;
            }
            set
            {
                this.IdClient = (global::LightSwitchApplication.Implementation.Client)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("IdClient");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Settlement.DetailsClass.IImplementation.IdRoom
        {
            get
            {
                return this.IdRoom;
            }
            set
            {
                this.IdRoom = (global::LightSwitchApplication.Implementation.Room)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("IdRoom");
                }
            }
        }
        
        partial void OnSettlement_ClientChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("IdClient");
            }
        }
        
        partial void OnSettlement_RoomChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("IdRoom");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Sex :
        global::LightSwitchApplication.Sex.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Sex.DetailsClass.IImplementation.ClientCollection
        {
            get
            {
                return this.ClientCollection;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class RoomType :
        global::LightSwitchApplication.RoomType.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.RoomType.DetailsClass.IImplementation.RoomCollection
        {
            get
            {
                return this.RoomCollection;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}
