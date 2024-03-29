// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.cell
{
    /// <summary>
	/// <para>Number cell renderer.</para>
	/// <para>Renders the call using the configured number formatter.</para>
	/// <para>EXPERIMENTAL!</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.cell.Number", OmitOptionalParameters = true, Export = false)]
    public partial class Number : qx.ui.virtualx.cell.Cell
    {
		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this cell.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>The number format used to render the cell</para>
		/// </summary>
		[JsProperty(Name = "numberFormat", NativeField = true)]
		public qx.util.format.NumberFormat NumberFormat { get; set; }

		#endregion Properties

		#region Methods

		public Number() { throw new NotImplementedException(); }

		/// <param name="numberFormat">Optional number format to use.</param>
		public Number(qx.util.format.NumberFormat numberFormat) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get cell&#8217;S HTML content</para>
		/// </summary>
		/// <param name="value">The cell&#8217;s data value</param>
		/// <param name="states">A map containing the cell&#8217;s state names as map keys.</param>
		/// <returns>The cell&#8217;s content as HTML fragment.</returns>
		[JsMethod(Name = "getContent")]
		public string GetContent(object value, object states) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property numberFormat.</para>
		/// </summary>
		[JsMethod(Name = "getNumberFormat")]
		public qx.util.format.NumberFormat GetNumberFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property numberFormat
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property numberFormat.</param>
		[JsMethod(Name = "initNumberFormat")]
		public void InitNumberFormat(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property numberFormat.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetNumberFormat")]
		public void ResetNumberFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property numberFormat.</para>
		/// </summary>
		/// <param name="value">New value for property numberFormat.</param>
		[JsMethod(Name = "setNumberFormat")]
		public void SetNumberFormat(qx.util.format.NumberFormat value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}