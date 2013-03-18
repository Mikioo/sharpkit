// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.tree.core
{
    /// <summary>
	/// <para>The small folder open/close button</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.tree.core.FolderOpenButton", OmitOptionalParameters = true, Export = false)]
    public partial class FolderOpenButton : qx.ui.basic.Image
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Open"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeOpen;

		/// <summary>
		/// Fired on change of the property <see cref="Command"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeCommand;

		/// <summary>
		/// <para>Fired if the <see cref="Execute"/> method is invoked.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnExecute;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Whether the button state is &#8220;open&#8221;</para>
		/// </summary>
		[JsProperty(Name = "open", NativeField = true)]
		public bool Open { get; set; }

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

		public FolderOpenButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property open.</para>
		/// </summary>
		[JsMethod(Name = "getOpen")]
		public bool GetOpen() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property open
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property open.</param>
		[JsMethod(Name = "initOpen")]
		public void InitOpen(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property open equals true.</para>
		/// </summary>
		[JsMethod(Name = "isOpen")]
		public void IsOpen() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property open.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOpen")]
		public void ResetOpen() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property open.</para>
		/// </summary>
		/// <param name="value">New value for property open.</param>
		[JsMethod(Name = "setOpen")]
		public void SetOpen(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property open.</para>
		/// </summary>
		[JsMethod(Name = "toggleOpen")]
		public void ToggleOpen() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Initiate the execute action.</para>
		/// </summary>
		[JsMethod(Name = "execute")]
		public void Execute() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property command.</para>
		/// </summary>
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
		/// <para>Sets the user value of the property command.</para>
		/// </summary>
		/// <param name="value">New value for property command.</param>
		[JsMethod(Name = "setCommand")]
		public void SetCommand(qx.ui.core.Command value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}