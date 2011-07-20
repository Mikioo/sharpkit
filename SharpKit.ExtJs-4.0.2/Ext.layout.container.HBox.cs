//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.layout.container
namespace Ext.layout.container
{
    #region HBox
    /// <summary>
    /// A layout that arranges items horizontally across a Container. This layout optionally divides available horizontal
    /// space between child items containing a numeric flex configuration. This layout may also be used to set the heights of child items by configuring it with the align option.
    /// Example usage: Ext.create(&#39;Ext.Panel&#39;, {
    /// width: 500,
    /// height: 300,
    /// title: &quot;HBoxLayout Panel&quot;,
    /// layout: {
    /// type: &#39;hbox&#39;,
    /// align: &#39;stretch&#39;
    /// },
    /// renderTo: document.body,
    /// items: [{
    /// xtype: &#39;panel&#39;,
    /// title: &#39;Inner Panel One&#39;,
    /// flex: 2
    /// },{
    /// xtype: &#39;panel&#39;,
    /// title: &#39;Inner Panel Two&#39;,
    /// flex: 1
    /// },{
    /// xtype: &#39;panel&#39;,
    /// title: &#39;Inner Panel Three&#39;,
    /// flex: 1
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class HBox : Box
    {
        public HBox(HBoxConfig config){}
        public HBox(){}
    }
    #endregion
    #region HBoxConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class HBoxConfig : BoxConfig
    {
        /// <summary>
        /// Controls how the child items of the container are aligned. ...
        /// </summary>
        public JsString align{get;set;}
    }
    #endregion
    #region HBoxEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class HBoxEvents : BoxEvents
    {
    }
    #endregion
}
#endregion
