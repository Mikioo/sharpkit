//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.direct
namespace Ext.direct
{
    #region Event
    /// <summary>
    /// A base class for all Ext.direct events. An event is
    /// created after some kind of interaction with the server.
    /// The event class is essentially just a data structure
    /// to hold a direct response.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Event : Ext.Base
    {
        /// <summary>
        /// Creates new Event. ...
        /// </summary>
        public Event(object config=null){}
        /// <summary>
        /// Return the raw data for this event. ...
        /// </summary>
        public object getData(){return null;}
        public Event(EventConfig config){}
    }
    #endregion
    #region EventConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class EventConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region EventEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class EventEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
