//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.tree.plugin
{
    #region TreeViewDragDrop
    /// <inheritdocs />
    /// <summary>
    /// <p>This plugin provides drag and/or drop functionality for a TreeView.</p>
    /// <p>It creates a specialized instance of <see cref="Ext.dd.DragZone">DragZone</see> which knows how to drag out of a
    /// <see cref="Ext.tree.View">TreeView</see> and loads the data object which is passed to a cooperating
    /// <see cref="Ext.dd.DragZone">DragZone</see>'s methods with the following properties:</p>
    /// <ul>
    /// <li><p>copy : Boolean</p>
    /// <p>The value of the TreeView's <c>copy</c> property, or <c>true</c> if the TreeView was configured with <c>allowCopy: true</c> <em>and</em>
    /// the control key was pressed when the drag operation was begun.</p></li>
    /// <li><p>view : TreeView</p>
    /// <p>The source TreeView from which the drag originated.</p></li>
    /// <li><p>ddel : HtmlElement</p>
    /// <p>The drag proxy element which moves with the mouse</p></li>
    /// <li><p>item : HtmlElement</p>
    /// <p>The TreeView node upon which the mousedown event was registered.</p></li>
    /// <li><p>records : Array</p>
    /// <p>An Array of <see cref="Ext.data.Model">Models</see> representing the selected data being dragged from the source TreeView.</p></li>
    /// </ul>
    /// <p>It also creates a specialized instance of <see cref="Ext.dd.DropZone">Ext.dd.DropZone</see> which cooperates with other DropZones which are
    /// members of the same ddGroup which processes such data objects.</p>
    /// <p>Adding this plugin to a view means that two new events may be fired from the client TreeView, <see cref="Ext.tree.plugin.TreeViewDragDropEvents.beforedrop">beforedrop</see> and
    /// <see cref="Ext.tree.plugin.TreeViewDragDropEvents.drop">drop</see>.</p>
    /// <p>Note that the plugin must be added to the tree view, not to the tree panel. For example using viewConfig:</p>
    /// <pre><code>viewConfig: {
    /// plugins: { ptype: 'treeviewdragdrop' }
    /// }
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class TreeViewDragDrop : AbstractPlugin
    {
        /// <summary>
        /// True if drops on the tree container (outside of a specific tree node) are allowed.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool allowContainerDrops;
        /// <summary>
        /// Allow inserting a dragged node between an expanded parent node and its first child that will become a sibling of
        /// the parent when dropped.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool allowParentInserts;
        /// <summary>
        /// True if the tree should only allow append drops (use for trees which are sorted).
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool appendOnly;
        /// <summary>
        /// A named drag drop group to which this object belongs. If a group is specified, then both the DragZones and
        /// DropZone used by this plugin will only interact with other drag drop objects in the same group.
        /// Defaults to: <c>&quot;TreeDD&quot;</c>
        /// </summary>
        public JsString ddGroup;
        /// <summary>
        /// The ddGroup to which the DragZone will belong.
        /// This defines which other DropZones the DragZone will interact with. Drag/DropZones only interact with other
        /// Drag/DropZones which are members of the same ddGroup.
        /// </summary>
        public JsString dragGroup;
        /// <summary>
        /// The text to show while dragging.
        /// Two placeholders can be used in the text:
        /// <li><c>{0}</c> The number of selected items.</li>
        /// <li><c>{1}</c> 's' when more than 1 items (only useful for English).</li>
        /// Defaults to: <c>&quot;{0} selected node{1}&quot;</c>
        /// </summary>
        public JsString dragText;
        /// <summary>
        /// The ddGroup to which the DropZone will belong.
        /// This defines which other DragZones the DropZone will interact with. Drag/DropZones only interact with other
        /// Drag/DropZones which are members of the same ddGroup.
        /// </summary>
        public JsString dropGroup;
        /// <summary>
        /// Set to false to disallow dragging items from the View.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool enableDrag;
        /// <summary>
        /// Set to false to disallow the View from accepting drop gestures.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool enableDrop;
        /// <summary>
        /// The delay in milliseconds to wait before expanding a target tree node while dragging a droppable node over the
        /// target.
        /// Defaults to: <c>1000</c>
        /// </summary>
        public JsString expandDelay;
        /// <summary>
        /// The color to use when visually highlighting the dragged or dropped node (default value is light blue).
        /// The color must be a 6 digit hex value, without a preceding '#'. See also nodeHighlightOnDrop and
        /// nodeHighlightOnRepair.
        /// Defaults to: <c>&quot;c3daf9&quot;</c>
        /// </summary>
        public JsString nodeHighlightColor;
        /// <summary>
        /// Whether or not to highlight any nodes after they are
        /// successfully dropped on their target. Defaults to the value of Ext.enableFx.
        /// See also nodeHighlightColor and nodeHighlightOnRepair.
        /// </summary>
        public bool nodeHighlightOnDrop;
        /// <summary>
        /// Whether or not to highlight any nodes after they are
        /// repaired from an unsuccessful drag/drop. Defaults to the value of Ext.enableFx.
        /// See also nodeHighlightColor and nodeHighlightOnDrop.
        /// </summary>
        public bool nodeHighlightOnRepair;
        public TreeViewDragDrop(TreeViewDragDropConfig config){}
        public TreeViewDragDrop(){}
        public TreeViewDragDrop(params object[] args){}
    }
    #endregion
    #region TreeViewDragDropConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TreeViewDragDropConfig : AbstractPluginConfig
    {
        /// <summary>
        /// True if drops on the tree container (outside of a specific tree node) are allowed.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool allowContainerDrops;
        /// <summary>
        /// Allow inserting a dragged node between an expanded parent node and its first child that will become a sibling of
        /// the parent when dropped.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool allowParentInserts;
        /// <summary>
        /// True if the tree should only allow append drops (use for trees which are sorted).
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool appendOnly;
        /// <summary>
        /// A named drag drop group to which this object belongs. If a group is specified, then both the DragZones and
        /// DropZone used by this plugin will only interact with other drag drop objects in the same group.
        /// Defaults to: <c>&quot;TreeDD&quot;</c>
        /// </summary>
        public JsString ddGroup;
        /// <summary>
        /// The ddGroup to which the DragZone will belong.
        /// This defines which other DropZones the DragZone will interact with. Drag/DropZones only interact with other
        /// Drag/DropZones which are members of the same ddGroup.
        /// </summary>
        public JsString dragGroup;
        /// <summary>
        /// The text to show while dragging.
        /// Two placeholders can be used in the text:
        /// <li><c>{0}</c> The number of selected items.</li>
        /// <li><c>{1}</c> 's' when more than 1 items (only useful for English).</li>
        /// Defaults to: <c>&quot;{0} selected node{1}&quot;</c>
        /// </summary>
        public JsString dragText;
        /// <summary>
        /// The ddGroup to which the DropZone will belong.
        /// This defines which other DragZones the DropZone will interact with. Drag/DropZones only interact with other
        /// Drag/DropZones which are members of the same ddGroup.
        /// </summary>
        public JsString dropGroup;
        /// <summary>
        /// Set to false to disallow dragging items from the View.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool enableDrag;
        /// <summary>
        /// Set to false to disallow the View from accepting drop gestures.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool enableDrop;
        /// <summary>
        /// The delay in milliseconds to wait before expanding a target tree node while dragging a droppable node over the
        /// target.
        /// Defaults to: <c>1000</c>
        /// </summary>
        public JsString expandDelay;
        /// <summary>
        /// The color to use when visually highlighting the dragged or dropped node (default value is light blue).
        /// The color must be a 6 digit hex value, without a preceding '#'. See also nodeHighlightOnDrop and
        /// nodeHighlightOnRepair.
        /// Defaults to: <c>&quot;c3daf9&quot;</c>
        /// </summary>
        public JsString nodeHighlightColor;
        /// <summary>
        /// Whether or not to highlight any nodes after they are
        /// successfully dropped on their target. Defaults to the value of Ext.enableFx.
        /// See also nodeHighlightColor and nodeHighlightOnRepair.
        /// </summary>
        public bool nodeHighlightOnDrop;
        /// <summary>
        /// Whether or not to highlight any nodes after they are
        /// repaired from an unsuccessful drag/drop. Defaults to the value of Ext.enableFx.
        /// See also nodeHighlightColor and nodeHighlightOnDrop.
        /// </summary>
        public bool nodeHighlightOnRepair;
        public TreeViewDragDropConfig(params object[] args){}
    }
    #endregion
    #region TreeViewDragDropEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TreeViewDragDropEvents : AbstractPluginEvents
    {
        /// <summary>
        /// This event is fired through the TreeView. Add listeners to the TreeView object
        /// Fired when a drop gesture has been triggered by a mouseup event in a valid drop position in the TreeView.
        /// </summary>
        /// <param name="node"><p>The TreeView node <strong>if any</strong> over which the mouse was positioned.</p>
        /// <p>Returning <c>false</c> to this event signals that the drop gesture was invalid, and if the drag proxy will animate
        /// back to the point from which the drag began.</p>
        /// <p>Returning <c>0</c> To this event signals that the data transfer operation should not take place, but that the gesture
        /// was valid, and that the repair operation should not take place.</p>
        /// <p>Any other return value continues with the data transfer operation.</p>
        /// </param>
        /// <param name="data"><p>The data object gathered at mousedown time by the cooperating
        /// <see cref="Ext.dd.DragZone">DragZone</see>'s <see cref="Ext.dd.DragZone.getDragData">getDragData</see> method it contains the following
        /// properties:</p>
        /// <ul><li><span>copy</span> : <see cref="bool">Boolean</see><div><p>The value of the TreeView's <c>copy</c> property, or <c>true</c> if the TreeView was configured with
        /// <c>allowCopy: true</c> and the control key was pressed when the drag operation was begun</p>
        /// </div></li><li><span>view</span> : <see cref="Ext.tree.View">Ext.tree.View</see><div><p>The source TreeView from which the drag originated.</p>
        /// </div></li><li><span>ddel</span> : HTMLElement<div><p>The drag proxy element which moves with the mouse</p>
        /// </div></li><li><span>item</span> : HTMLElement<div><p>The TreeView node upon which the mousedown event was registered.</p>
        /// </div></li><li><span>records</span> : <see cref="Ext.data.Model">Ext.data.Model</see>[]<div><p>An Array of <see cref="Ext.data.Model">Model</see>s representing the selected data being
        /// dragged from the source TreeView.</p>
        /// </div></li></ul></param>
        /// <param name="overModel"><p>The Model over which the drop gesture took place.</p>
        /// </param>
        /// <param name="dropPosition"><p><c>"before"</c>, <c>"after"</c> or <c>"append"</c> depending on whether the mouse is above or below
        /// the midline of the node, or the node is a branch node which accepts new child nodes.</p>
        /// </param>
        /// <param name="dropHandler"><p>An object containing methods to complete/cancel the data transfer operation and either
        /// move or copy Model instances from the source View's Store to the destination View's Store.</p>
        /// <p>This is useful when you want to perform some kind of asynchronous processing before confirming/cancelling
        /// the drop, such as an <see cref="Ext.window.MessageBox.confirm">confirm</see> call, or an Ajax request.</p>
        /// <p>Set dropHandler.wait = true in this event handler to delay processing. When you want to complete the event, call
        /// dropHandler.processDrop(). To cancel the drop, call dropHandler.cancelDrop.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforedrop(object node, JsArray<Object> data, Ext.data.Model overModel, JsString dropPosition, object dropHandler, object eOpts){}
        /// <summary>
        /// This event is fired through the TreeView. Add listeners to the TreeView object Fired when a drop operation
        /// has been completed and the data has been moved or copied.
        /// </summary>
        /// <param name="node"><p>The TreeView node <strong>if any</strong> over which the mouse was positioned.</p>
        /// </param>
        /// <param name="data"><p>The data object gathered at mousedown time by the cooperating
        /// <see cref="Ext.dd.DragZone">DragZone</see>'s <see cref="Ext.dd.DragZone.getDragData">getDragData</see> method it contains the following
        /// properties:</p>
        /// <ul><li><span>copy</span> : <see cref="bool">Boolean</see><div><p>The value of the TreeView's <c>copy</c> property, or <c>true</c> if the TreeView was configured with
        /// <c>allowCopy: true</c> and the control key was pressed when the drag operation was begun</p>
        /// </div></li><li><span>view</span> : <see cref="Ext.tree.View">Ext.tree.View</see><div><p>The source TreeView from which the drag originated.</p>
        /// </div></li><li><span>ddel</span> : HTMLElement<div><p>The drag proxy element which moves with the mouse</p>
        /// </div></li><li><span>item</span> : HTMLElement<div><p>The TreeView node upon which the mousedown event was registered.</p>
        /// </div></li><li><span>records</span> : <see cref="Ext.data.Model">Ext.data.Model</see>[]<div><p>An Array of <see cref="Ext.data.Model">Model</see>s representing the selected data being
        /// dragged from the source TreeView.</p>
        /// </div></li></ul></param>
        /// <param name="overModel"><p>The Model over which the drop gesture took place.</p>
        /// </param>
        /// <param name="dropPosition"><p><c>"before"</c>, <c>"after"</c> or <c>"append"</c> depending on whether the mouse is above or below
        /// the midline of the node, or the node is a branch node which accepts new child nodes.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void drop(object node, JsArray<Object> data, Ext.data.Model overModel, JsString dropPosition, object eOpts){}
        public TreeViewDragDropEvents(params object[] args){}
    }
    #endregion
}