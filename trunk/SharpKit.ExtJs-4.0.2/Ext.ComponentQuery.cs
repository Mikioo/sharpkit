//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region ComponentQuery
    /// <summary>
    /// Provides searching of Components within Ext.ComponentManager (globally) or a specific
    /// Ext.container.Container on the document with a similar syntax to a CSS selector. Components can be retrieved by using their xtype with an optional . prefix  component or .component gridpanel or .gridpanel  An itemId or id must be prefixed with a #  #myContainer  Attributes must be wrapped in brackets  component[autoScroll] panel[title=&quot;Test&quot;]  Member expressions from candidate Components may be tested. If the expression returns a truthy value,
    /// the candidate Component will be included in the query: var disabledFields = myFormPanel.query(&quot;{isDisabled()}&quot;);
    /// Pseudo classes may be used to filter results in the same way as in DomQuery: // Function receives array and returns a filtered array.
    /// Ext.ComponentQuery.pseudos.invalid = function(items) {
    /// var i = 0, l = items.length, c, result = [];
    /// for (; i &amp;lt; l; i++) {
    /// if (!(c = items[i]).isValid()) {
    /// result.push(c);
    /// }
    /// }
    /// return result;
    /// };
    /// var invalidFields = myFormPanel.query(&#39;field:invalid&#39;);
    /// if (invalidFields.length) {
    /// invalidFields[0].getEl().scrollIntoView(myFormPanel.body);
    /// for (var i = 0, l = invalidFields.length; i &amp;lt; l; i++) {
    /// invalidFields[i].getEl().frame(&quot;red&quot;);
    /// }
    /// }
    /// Default pseudos include:  not  Queries return an array of components.
    /// Here are some example queries. // retrieve all Ext.Panels in the document by xtype
    /// var panelsArray = Ext.ComponentQuery.query(&#39;panel&#39;);
    /// // retrieve all Ext.Panels within the container with an id myCt
    /// var panelsWithinmyCt = Ext.ComponentQuery.query(&#39;#myCt panel&#39;);
    /// // retrieve all direct children which are Ext.Panels within myCt
    /// var directChildPanel = Ext.ComponentQuery.query(&#39;#myCt &amp;gt; panel&#39;);
    /// // retrieve all grids and trees
    /// var gridsAndTrees = Ext.ComponentQuery.query(&#39;gridpanel, treepanel&#39;);
    /// For easy access to queries based from a particular Container see the Ext.container.Container.query,
    /// Ext.container.Container.down and Ext.container.Container.child methods. Also see
    /// Ext.Component.up.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ComponentQuery
    {
        /// <summary>
        /// Tests whether the passed Component matches the selector string. ...
        /// </summary>
        public static bool @is(Ext.Component component, JsString selector){return false;}
        /// <summary>
        /// Returns an array of matched Components from within the passed root object. ...
        /// </summary>
        public static Ext.Component query(JsString selector, Ext.container.Container root){return null;}
        public ComponentQuery(ComponentQueryConfig config){}
        public ComponentQuery(){}
    }
    #endregion
    #region ComponentQueryConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ComponentQueryConfig
    {
    }
    #endregion
    #region ComponentQueryEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ComponentQueryEvents
    {
    }
    #endregion
}
#endregion