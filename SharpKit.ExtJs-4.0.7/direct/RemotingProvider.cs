//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.direct
namespace Ext.direct
{
    #region RemotingProvider
    /// <summary>
    /// The RemotingProvider exposes access to
    /// server side methods on the client (a remote procedure call (RPC) type of
    /// connection where the client can initiate a procedure on the server). This allows for code to be organized in a fashion that is maintainable,
    /// while providing a clear path between client and server, something that is
    /// not always apparent when using URLs. To accomplish this the server-side needs to describe what classes and methods
    /// are available on the client-side. This configuration will typically be
    /// outputted by the server-side Ext.Direct stack when the API description is built.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class RemotingProvider : JsonProvider, Ext.util.Observable
    {
        public RemotingProvider(RemotingProviderConfig config){}
        public RemotingProvider(){}
    }
    #endregion
    #region RemotingProviderConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RemotingProviderConfig : JsonProviderConfig
    {
        /// <summary>
        /// Object literal defining the server side actions and methods. ...
        /// </summary>
        public object actions{get;set;}
        /// <summary>
        /// true or false to enable or disable combining of method
        /// calls. ...
        /// </summary>
        public object enableBuffer{get;set;}
        /// <summary>
        /// Specify which param will hold the arguments for the method. ...
        /// </summary>
        public JsString enableUrlEncode{get;set;}
        /// <summary>
        /// Number of times to re-attempt delivery on failure of a call. ...
        /// </summary>
        public JsNumber maxRetries{get;set;}
        /// <summary>
        /// Namespace for the Remoting Provider (defaults to the browser global scope of window). ...
        /// </summary>
        public object @namespace{get;set;}
        /// <summary>
        /// The timeout to use for each request. ...
        /// </summary>
        public JsNumber timeout{get;set;}
        /// <summary>
        /// Required. ...
        /// </summary>
        public JsString url{get;set;}
    }
    #endregion
    #region RemotingProviderEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RemotingProviderEvents : JsonProviderEvents
    {
        /// <summary>
        /// Fires immediately before the client-side sends off the RPC call. ...
        /// </summary>
        public static JsString beforecall="beforecall";
        /// <summary>
        /// Fires immediately after the request to the server-side is sent. ...
        /// </summary>
        public static JsString call="call";
    }
    #endregion
}
#endregion
