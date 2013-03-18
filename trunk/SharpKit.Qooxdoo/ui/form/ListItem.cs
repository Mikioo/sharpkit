// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>A item for a list. Could be added to all List like widgets but also
	/// to the <see cref="qx.ui.form.SelectBox"/> and <see cref="qx.ui.form.ComboBox"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.ListItem", OmitOptionalParameters = true, Export = false)]
    public partial class ListItem : qx.ui.basic.Atom, qx.ui.form.IModel
    {
		#region Events

		/// <summary>
		/// <para>(Fired by <see cref="qx.ui.form.List"/>)</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnAction;

		/// <summary>
		/// <para>Fired when the model data changes</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		#endregion Events

		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>Model property for storing additional information for the including
		/// object. It can act as value property on form items for example.</para>
		/// <para>Be careful using that property as this is used for the
		/// <see cref="qx.ui.form.MModelSelection"/> it has some restrictions:</para>
		/// <list type="bullet">
		/// <item>Don&#8217;t use equal models in one widget using the
		/// <see cref="qx.ui.form.MModelSelection"/>.</item>
		/// </list
		/// <list type="bullet">
		/// <item>Avoid setting only some model properties if the widgets are added to
		/// a <see cref="qx.ui.form.MModelSelection"/> widge.</item>
		/// </list
		/// <para>Both restrictions result of the fact, that the set models are deputies
		/// for their widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public object Model { get; set; }

		#endregion Properties

		#region Methods

		public ListItem() { throw new NotImplementedException(); }

		/// <param name="label">Label to use</param>
		/// <param name="icon">Icon to use</param>
		/// <param name="model">The items value</param>
		public ListItem(string label, string icon = null, string model = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the representative data for the item</para>
		/// </summary>
		/// <returns>The data.</returns>
		[JsMethod(Name = "getModel")]
		public object GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the representative data to null.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the representative data for the item.</para>
		/// </summary>
		/// <param name="value">The data.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}