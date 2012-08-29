//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.proxy
namespace Ext.data.proxy
{
    #region SessionStorage
    /// <inheritdocs />
    /// <summary>
    /// <p>Proxy which uses HTML5 session storage as its data storage/retrieval mechanism. If this proxy is used in a browser
    /// where session storage is not supported, the constructor will throw an error. A session storage proxy requires a
    /// unique ID which is used as a key in which all record data are stored in the session storage object.</p>
    /// <p>It's important to supply this unique ID as it cannot be reliably determined otherwise. If no id is provided but the
    /// attached store has a storeId, the storeId will be used. If neither option is presented the proxy will throw an error.</p>
    /// <p>Proxies are almost always used with a <see cref="Ext.data.Store">store</see>:</p>
    /// <pre><code>new <see cref="Ext.data.Store">Ext.data.Store</see>({
    /// proxy: {
    /// type: 'sessionstorage',
    /// id  : 'myProxyKey'
    /// }
    /// });
    /// </code></pre>
    /// <p>Alternatively you can instantiate the Proxy directly:</p>
    /// <pre><code>new <see cref="Ext.data.proxy.SessionStorage">Ext.data.proxy.SessionStorage</see>({
    /// id  : 'myOtherProxyKey'
    /// });
    /// </code></pre>
    /// <p>Note that session storage is different to local storage (see <see cref="Ext.data.proxy.LocalStorage">Ext.data.proxy.LocalStorage</see>) - if a browser
    /// session is ended (e.g. by closing the browser) then all data in a SessionStorageProxy are lost. Browser restarts
    /// don't affect the <see cref="Ext.data.proxy.LocalStorage">Ext.data.proxy.LocalStorage</see> - the data are preserved.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class SessionStorage : WebStorage
    {
        public SessionStorage(SessionStorageConfig config){}
        public SessionStorage(){}
        public SessionStorage(params object[] args){}
    }
    #endregion
    #region SessionStorageConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SessionStorageConfig : WebStorageConfig
    {
        public SessionStorageConfig(params object[] args){}
    }
    #endregion
    #region SessionStorageEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SessionStorageEvents : WebStorageEvents
    {
        public SessionStorageEvents(params object[] args){}
    }
    #endregion
}
#endregion
