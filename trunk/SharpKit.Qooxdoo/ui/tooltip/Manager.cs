// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.tooltip
{
    /// <summary>
	/// <para>The tooltip manager globally manages the tooltips of all widgets. It will
	/// display tooltips if the user hovers a widgets with a tooltip and hides all
	/// other tooltips.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.tooltip.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager : qx.core.Object
    {
		#region Properties

		/// <summary>
		/// <para>Holds the current ToolTip instance</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "current", NativeField = true)]
		public qx.ui.tooltip.ToolTip Current { get; set; }

		/// <summary>
		/// <para>Show all invalid form fields tooltips .</para>
		/// </summary>
		[JsProperty(Name = "showInvalidToolTips", NativeField = true)]
		public bool ShowInvalidToolTips { get; set; }

		/// <summary>
		/// <para>Show all tooltips.</para>
		/// </summary>
		[JsProperty(Name = "showToolTips", NativeField = true)]
		public bool ShowToolTips { get; set; }

		#endregion Properties

		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property current.</para>
		/// </summary>
		[JsMethod(Name = "getCurrent")]
		public qx.ui.tooltip.ToolTip GetCurrent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the shared tooltip, which is used to display the
		/// <see cref="qx.ui.core.Widget.ToolTipText"/> and
		/// <see cref="qx.ui.core.Widget.ToolTipIcon"/> properties of widgets.
		/// You can use this public shared instance to e.g. customize the
		/// look and feel of the validation tooltips like
		/// getSharedErrorTooltip().getChildControl(&#8220;atom&#8221;).getChildControl(&#8220;label&#8221;).set({rich: true, wrap: true, width: 80})</para>
		/// </summary>
		/// <returns>The shared tooltip</returns>
		[JsMethod(Name = "getSharedErrorTooltip")]
		public qx.ui.tooltip.ToolTip GetSharedErrorTooltip() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the shared tooltip, which is used to display the
		/// <see cref="qx.ui.core.Widget.ToolTipText"/> and
		/// <see cref="qx.ui.core.Widget.ToolTipIcon"/> properties of widgets.
		/// You can use this public shared instance to e.g. customize the
		/// look and feel.</para>
		/// </summary>
		/// <returns>The shared tooltip</returns>
		[JsMethod(Name = "getSharedTooltip")]
		public qx.ui.tooltip.ToolTip GetSharedTooltip() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showInvalidToolTips.</para>
		/// </summary>
		[JsMethod(Name = "getShowInvalidToolTips")]
		public bool GetShowInvalidToolTips() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property showToolTips.</para>
		/// </summary>
		[JsMethod(Name = "getShowToolTips")]
		public bool GetShowToolTips() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property current
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property current.</param>
		[JsMethod(Name = "initCurrent")]
		public void InitCurrent(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showInvalidToolTips
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showInvalidToolTips.</param>
		[JsMethod(Name = "initShowInvalidToolTips")]
		public void InitShowInvalidToolTips(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property showToolTips
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property showToolTips.</param>
		[JsMethod(Name = "initShowToolTips")]
		public void InitShowToolTips(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showInvalidToolTips equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowInvalidToolTips")]
		public void IsShowInvalidToolTips() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property showToolTips equals true.</para>
		/// </summary>
		[JsMethod(Name = "isShowToolTips")]
		public void IsShowToolTips() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property current.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCurrent")]
		public void ResetCurrent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showInvalidToolTips.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowInvalidToolTips")]
		public void ResetShowInvalidToolTips() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property showToolTips.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShowToolTips")]
		public void ResetShowToolTips() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property current.</para>
		/// </summary>
		/// <param name="value">New value for property current.</param>
		[JsMethod(Name = "setCurrent")]
		public void SetCurrent(qx.ui.tooltip.ToolTip value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showInvalidToolTips.</para>
		/// </summary>
		/// <param name="value">New value for property showInvalidToolTips.</param>
		[JsMethod(Name = "setShowInvalidToolTips")]
		public void SetShowInvalidToolTips(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property showToolTips.</para>
		/// </summary>
		/// <param name="value">New value for property showToolTips.</param>
		[JsMethod(Name = "setShowToolTips")]
		public void SetShowToolTips(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Explicitly show tooltip for particular form item.</para>
		/// </summary>
		/// <param name="target">widget to show tooltip for</param>
		[JsMethod(Name = "showToolTip")]
		public void ShowToolTip(object target) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showInvalidToolTips.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowInvalidToolTips")]
		public void ToggleShowInvalidToolTips() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property showToolTips.</para>
		/// </summary>
		[JsMethod(Name = "toggleShowToolTips")]
		public void ToggleShowToolTips() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.ui.tooltip.Manager GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}