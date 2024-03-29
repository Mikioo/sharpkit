//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
using Ext.direct;
#region Ext.dd
namespace Ext.dd
{
    #region Registry
    /// <summary>
    /// Provides easy access to all drag drop components that are registered on a page.  Items can be retrieved either
    /// directly by DOM node id, or by passing in the drag drop event that occurred and looking up the event target.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Registry : Ext.Base
    {
        /// <summary>
        /// Returns the handle registered for a DOM Node by id ...
        /// </summary>
        public static object getHandle(object id){return null;}
        /// <summary>
        /// Returns the handle that is registered for the DOM node that is the target of the event ...
        /// </summary>
        public static object getHandleFromEvent(Event e){return null;}
        /// <summary>
        /// Returns a custom data object that is registered for a DOM node by id ...
        /// </summary>
        public static object getTarget(object id){return null;}
        /// <summary>
        /// Returns a custom data object that is registered for the DOM node that is the target of the event ...
        /// </summary>
        public static object getTargetFromEvent(Event e){return null;}
        /// <summary>
        /// Resgister a drag drop element ...
        /// </summary>
        public static object register(object element, object data=null){return null;}
        /// <summary>
        /// Unregister a drag drop element ...
        /// </summary>
        public static object unregister(object element){return null;}
        public Registry(RegistryConfig config){}
        public Registry(){}
    }
    #endregion
    #region RegistryConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RegistryConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region RegistryEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RegistryEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
