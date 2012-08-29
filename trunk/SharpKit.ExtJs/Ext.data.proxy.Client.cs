//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.proxy
namespace Ext.data.proxy
{
    #region Client
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Base class for any client-side storage. Used as a superclass for <see cref="Ext.data.proxy.Memory">Memory</see> and
    /// <see cref="Ext.data.proxy.WebStorage">Web Storage</see> proxies. Do not use directly, use one of the subclasses instead.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Client : Ext.data.proxy.Proxy
    {
        /// <summary>
        /// true in this class to identify that requests made on this proxy are
        /// performed synchronously
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isSynchronous{get;set;}
        /// <summary>
        /// Abstract function that must be implemented by each ClientProxy subclass. This should purge all record data
        /// from the client side storage, as well as removing any supporting data (such as lists of record IDs)
        /// </summary>
        public void clear(){}
        public Client(ClientConfig config){}
        public Client(){}
        public Client(params object[] args){}
    }
    #endregion
    #region ClientConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ClientConfig : Ext.data.proxy.ProxyConfig
    {
        public ClientConfig(params object[] args){}
    }
    #endregion
    #region ClientEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ClientEvents : Ext.data.proxy.ProxyEvents
    {
        public ClientEvents(params object[] args){}
    }
    #endregion
}
#endregion
