//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid
namespace Ext.grid
{
    #region CellEditor
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Internal utility class that provides default configuration for cell editing.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class CellEditor : Ext.Editor
    {
        /// <summary>
        /// Restore checkbox focus and completeEdit method.
        /// </summary>
        private void onCheckBoxClick(){}
        /// <summary>
        /// Because when checkbox is clicked it loses focus  completeEdit is bypassed.
        /// </summary>
        private void onCheckBoxMouseDown(){}
        /// <summary>
        /// Show the grid cell text when the editor is hidden by adding the text back to the text node
        /// Overrides: <see cref="Ext.Component.onHide">Ext.Component.onHide</see>
        /// </summary>
        private void onHide(){}
        /// <summary>
        /// Hide the grid cell text when editor is shown.
        /// There are 2 reasons this needs to happen:
        /// <li><p>checkbox editor does not take up enough space to hide the underlying text.</p></li>
        /// <li><p>When columnLines are turned off in browsers that don't support text-overflow:
        /// ellipsis (firefox 6 and below and IE quirks), the text extends to the last pixel
        /// in the cell, however the right border of the cell editor is always positioned 1px
        /// offset from the edge of the cell (to give it the appearance of being "inside" the
        /// cell.  This results in 1px of the underlying cell text being visible to the right
        /// of the cell editor if the text is not hidden.</p></li>
        /// We can't just hide the entire cell, because then treecolumn's icons would be hidden
        /// as well.  We also can't just set "color: transparent" to hide the text because it is
        /// not supported by IE8 and below.  The only remaining solution is to remove the text
        /// from the text node and then add it back when the editor is hidden.
        /// Overrides: <see cref="Ext.Component.onShow">Ext.Component.onShow</see>
        /// </summary>
        private void onShow(){}
        public CellEditor(CellEditorConfig config){}
        public CellEditor(){}
        public CellEditor(params object[] args){}
    }
    #endregion
    #region CellEditorConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CellEditorConfig : Ext.EditorConfig
    {
        public CellEditorConfig(params object[] args){}
    }
    #endregion
    #region CellEditorEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CellEditorEvents : Ext.EditorEvents
    {
        public CellEditorEvents(params object[] args){}
    }
    #endregion
}
#endregion
