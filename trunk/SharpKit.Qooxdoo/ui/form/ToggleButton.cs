// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.form
{
    /// <summary>
	/// <para>A toggle Button widget</para>
	/// <para>If the user presses the button by clicking on it pressing the enter or
	/// space key, the button toggles between the pressed an not pressed states.
	/// There is no execute event, only a <see cref="qx.ui.form.ToggleButton.ChangeValue"/>
	/// event.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.ToggleButton", OmitOptionalParameters = true, Export = false)]
    public partial class ToggleButton : qx.ui.basic.Atom, qx.ui.form.IBooleanForm, qx.ui.form.IExecutable, qx.ui.form.IRadioItem
    {
		#region Events

		/// <summary>
		/// <para>Fired when the item was checked or unchecked</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValue;

		/// <summary>
		/// Fired on change of the property <see cref="Command"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeCommand;

		/// <summary>
		/// <para>Fired when the widget is executed. Sets the &#8220;data&#8221; property of the
		/// event to the object that issued the command.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnExecute;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Whether the widget is focusable e.g. rendering a focus border and visualize
		/// as active element.</para>
		/// <para>See also <see cref="IsTabable"/> which allows runtime checks for
		/// isChecked or other stuff to test whether the widget is
		/// reachable via the TAB key.</para>
		/// </summary>
		[JsProperty(Name = "focusable", NativeField = true)]
		public bool Focusable { get; set; }

		/// <summary>
		/// <para>The assigned qx.ui.form.RadioGroup which handles the switching between registered buttons.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "group", NativeField = true)]
		public qx.ui.form.RadioGroup Group { get; set; }

		/// <summary>
		/// <para>Whether the button has a third state. Use this for tri-state checkboxes.</para>
		/// <para>When enabled, the value null of the property value stands for &#8220;undetermined&#8221;,
		/// while true is mapped to &#8220;enabled&#8221; and false to &#8220;disabled&#8221; as usual. Note
		/// that the value property is set to false initially.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "triState", NativeField = true)]
		public bool TriState { get; set; }

		/// <summary>
		/// <para>The value of the widget. True, if the widget is checked.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "value", NativeField = true)]
		public bool Value { get; set; }

		/// <summary>
		/// <para>A command called if the <see cref="Execute"/> method is called, e.g. on a
		/// button click.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "command", NativeField = true)]
		public qx.ui.core.Command Command { get; set; }

		#endregion Properties

		#region Methods

		public ToggleButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a ToggleButton.</para>
		/// </summary>
		/// <param name="label">The text on the button.</param>
		/// <param name="icon">An URI to the icon of the button.</param>
		public ToggleButton(string label, string icon) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the radiogroup, which manages this item</para>
		/// </summary>
		/// <returns>The radiogroup, which manages the item.</returns>
		[JsMethod(Name = "getGroup")]
		public qx.ui.form.RadioGroup GetGroup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property triState.</para>
		/// </summary>
		[JsMethod(Name = "getTriState")]
		public bool GetTriState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get whether the item is checked</para>
		/// </summary>
		/// <returns>whether the item it checked</returns>
		[JsMethod(Name = "getValue")]
		public bool GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property group
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property group.</param>
		[JsMethod(Name = "initGroup")]
		public void InitGroup(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property triState
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property triState.</param>
		[JsMethod(Name = "initTriState")]
		public void InitTriState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property value
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property value.</param>
		[JsMethod(Name = "initValue")]
		public void InitValue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property triState equals true.</para>
		/// </summary>
		[JsMethod(Name = "isTriState")]
		public void IsTriState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property value equals true.</para>
		/// </summary>
		[JsMethod(Name = "isValue")]
		public void IsValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property group.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGroup")]
		public void ResetGroup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property triState.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTriState")]
		public void ResetTriState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the radiogroup, which manages this item</para>
		/// </summary>
		/// <param name="value">The radiogroup, which should manage the item.</param>
		[JsMethod(Name = "setGroup")]
		public void SetGroup(qx.ui.form.RadioGroup value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property triState.</para>
		/// </summary>
		/// <param name="value">New value for property triState.</param>
		[JsMethod(Name = "setTriState")]
		public void SetTriState(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set whether the item is checked</para>
		/// </summary>
		/// <param name="value">whether the item should be checked</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property triState.</para>
		/// </summary>
		[JsMethod(Name = "toggleTriState")]
		public void ToggleTriState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property value.</para>
		/// </summary>
		[JsMethod(Name = "toggleValue")]
		public void ToggleValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Fire the &#8220;execute&#8221; event on the command.</para>
		/// </summary>
		[JsMethod(Name = "execute")]
		public void Execute() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current set command of this executable.</para>
		/// </summary>
		/// <returns>The current set command.</returns>
		[JsMethod(Name = "getCommand")]
		public qx.ui.core.Command GetCommand() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property command
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property command.</param>
		[JsMethod(Name = "initCommand")]
		public void InitCommand(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property command.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCommand")]
		public void ResetCommand() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the command of this executable.</para>
		/// </summary>
		/// <param name="command">The command.</param>
		[JsMethod(Name = "setCommand")]
		public void SetCommand(qx.ui.core.Command command) { throw new NotImplementedException(); }

		#endregion Methods
    }
}