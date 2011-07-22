//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region FocusManager
    /// <summary>
    /// The FocusManager is responsible for globally:  Managing component focus Providing basic keyboard navigation (optional) Provide a visual cue for focused components, in the form of a focus ring/frame.  To activate the FocusManager, simply call &amp;lt;code&amp;gt;Ext.FocusManager.enable();&amp;lt;/code&amp;gt;. In turn, you may
    /// deactivate the FocusManager by subsequently calling &amp;lt;code&amp;gt;Ext.FocusManager.disable();&amp;lt;/code&amp;gt;.  The
    /// FocusManager is disabled by default. To enable the optional focus frame, pass true or {focusFrame: true} to enable. Another feature of the FocusManager is to provide basic keyboard focus navigation scoped to any Ext.container.Container
    /// that would like to have navigation between its child Ext.Component&#39;s. The Ext.container.Container can simply
    /// call Ext.FocusManager.subscribe to take advantage of this feature, and can at any time call
    /// Ext.FocusManager.unsubscribe to turn the navigation off.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class FocusManager : Ext.Base//, Ext.util.Observable
    {
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public static object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public static object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public static object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Adds the specified xtype to the whitelist. ...
        /// </summary>
        public static object addXTypeToWhitelist(object xtype){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public static object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public static object clearManagedListeners(){return null;}
        /// <summary>
        /// Disables the FocusManager by turning of all automatic focus management and keyboard navigation ...
        /// </summary>
        public static object disable(){return null;}
        /// <summary>
        /// Enables the FocusManager by turning on all automatic focus management and keyboard navigation ...
        /// </summary>
        public static object enable(object options){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public static object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public static bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public static bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public static object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public static object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public static object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public static object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public static object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public static object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Removes the specified xtype from the whitelist. ...
        /// </summary>
        public static object removeXTypeFromWhitelist(object xtype){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public static object resumeEvents(){return null;}
        /// <summary>
        /// Subscribes an Ext.container.Container to provide basic keyboard focus navigation between its child Ext.Component's. ...
        /// </summary>
        public static object subscribe(Ext.container.Container container, object options=null){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public static object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public static object un(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Unsubscribes an Ext.container.Container from keyboard focus management. ...
        /// </summary>
        public static object unsubscribe(Ext.container.Container container){return null;}
        public static bool enabled{get;set;}
        /// <summary>
        /// The currently focused component. ...
        /// </summary>
        public static Ext.Component focusedCmp{get;set;}
        /// <summary>
        /// A list of xtypes that should ignore certain navigation input keys and
        /// allow for the default browser event/behavior. ...
        /// </summary>
        public static JsArray whitelist{get;set;}
        public FocusManager(FocusManagerConfig config){}
        public FocusManager(){}
    }
    #endregion
    #region FocusManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class FocusManagerConfig : Ext.BaseConfig
    {
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
    }
    #endregion
    #region FocusManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class FocusManagerEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires before a component becomes focused. ...
        /// </summary>
        public static JsString beforecomponentfocus="beforecomponentfocus";
        /// <summary>
        /// Fires after a component becomes focused. ...
        /// </summary>
        public static JsString componentfocus="componentfocus";
        /// <summary>
        /// Fires when the FocusManager is disabled ...
        /// </summary>
        public static JsString disable="disable";
        /// <summary>
        /// Fires when the FocusManager is enabled ...
        /// </summary>
        public static JsString enable="enable";
    }
    #endregion
}
#endregion
