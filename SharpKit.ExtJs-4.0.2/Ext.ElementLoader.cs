//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region ElementLoader
    /// <summary>
    /// A class used to load remote content to an Element. Sample usage: Ext.get(&#39;el&#39;).load({
    /// url: &#39;myPage.php&#39;,
    /// scripts: true,
    /// params: {
    /// id: 1
    /// }
    /// });
    /// In general this class will not be instanced directly, rather the Ext.core.Element.load method
    /// will be used.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ElementLoader : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Aborts the active load request ...
        /// </summary>
        public object abort(){return null;}
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Destroys the loader. ...
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Get the target of this loader. ...
        /// </summary>
        public Ext.Component getTarget(){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Checks whether the loader is automatically refreshing. ...
        /// </summary>
        public bool isAutoRefreshing(){return false;}
        /// <summary>
        /// Load new data from the server. ...
        /// </summary>
        public object load(object options){return null;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Set an {Ext.Element} as the target of this loader. ...
        /// </summary>
        public object setTarget(object target){return null;}
        /// <summary>
        /// Automatically refreshes the content over a specified period. ...
        /// </summary>
        public object startAutoRefresh(JsNumber interval, object options=null){return null;}
        /// <summary>
        /// Clears any auto refresh. ...
        /// </summary>
        public object stopAutoRefresh(){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        public ElementLoader(ElementLoaderConfig config){}
        public ElementLoader(){}
    }
    #endregion
    #region ElementLoaderConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ElementLoaderConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Any additional options to be passed to the request, for example timeout or headers. ...
        /// </summary>
        public object ajaxOptions{get;set;}
        /// <summary>
        /// True to have the loader make a request as soon as it is created. ...
        /// </summary>
        public object autoLoad{get;set;}
        /// <summary>
        /// Params that will be attached to every request. ...
        /// </summary>
        public object baseParams{get;set;}
        public JsAction failure{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        public object loadMask{get;set;}
        /// <summary>
        /// Any params to be attached to the Ajax request. ...
        /// </summary>
        public object @params{get;set;}
        /// <summary>
        /// A custom function to render the content to the element. ...
        /// </summary>
        public JsAction renderer{get;set;}
        public object scope{get;set;}
        public bool scripts{get;set;}
        public JsAction success{get;set;}
        /// <summary>
        /// The target element for the loader. ...
        /// </summary>
        public object target{get;set;}
        /// <summary>
        /// The url to retrieve the content from. ...
        /// </summary>
        public JsString url{get;set;}
    }
    #endregion
    #region ElementLoaderEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ElementLoaderEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires before a load request is made to the server. ...
        /// </summary>
        public static JsString beforeload="beforeload";
        /// <summary>
        /// Fires after a successful load. ...
        /// </summary>
        public static JsString exception="exception";
    }
    #endregion
}
#endregion
