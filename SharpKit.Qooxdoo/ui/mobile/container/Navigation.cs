// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.mobile.container
{
    /// <summary>
	/// <para>The navigation controller includes already a <see cref="qx.ui.mobile.navigationbar.NavigationBar"/>
	/// and a <see cref="qx.ui.mobile.container.Composite"/> container with a <see cref="qx.ui.mobile.layout.Card"/> layout.
	/// All widgets that implement the <see cref="qx.ui.mobile.container.INavigation"/>
	/// interface can be added to the container. The added widget provide the title
	/// widget and the left/right container, which will be automatically merged into
	/// navigation bar.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var container = new qx.ui.mobile.container.Navigation();
	/// this.getRoot(container);
	/// var page = new qx.ui.mobile.page.NavigationPage();
	/// container.add(page);
	/// page.show();
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.container.Navigation", OmitOptionalParameters = true, Export = false)]
    public partial class Navigation : qx.ui.mobile.container.Composite
    {
		#region Events

		/// <summary>
		/// <para>Fired when the navigation bar gets updated</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnUpdate;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The default CSS class used for this widget. The default CSS class
		/// should contain the common appearance of the widget.
		/// It is set to the container element of the widget. Use <see cref="AddCssClass"/>
		/// to enhance the default appearance of the widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public string DefaultCssClass { get; set; }

		#endregion Properties

		#region Methods

		public Navigation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new child widget.</para>
		/// </summary>
		/// <param name="child">the widget to add.</param>
		/// <param name="layoutProperties">Optional layout data for widget.</param>
		[JsMethod(Name = "add")]
		public void Add(Widget child, object layoutProperties = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the content container. Add all your widgets to this container.</para>
		/// </summary>
		/// <returns>The content container</returns>
		[JsMethod(Name = "getContent")]
		public qx.ui.mobile.container.Composite GetContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the assigned card layout.</para>
		/// </summary>
		/// <returns>assigned Card Layout.</returns>
		[JsMethod(Name = "getLayout")]
		public qx.ui.mobile.layout.Card GetLayout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the navigation bar.</para>
		/// </summary>
		/// <returns>The navigation bar.</returns>
		[JsMethod(Name = "getNavigationBar")]
		public qx.ui.mobile.navigationbar.NavigationBar GetNavigationBar() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the given child widget.</para>
		/// </summary>
		/// <param name="child">the widget to remove</param>
		[JsMethod(Name = "remove")]
		public void Remove(Widget child) { throw new NotImplementedException(); }

		#endregion Methods
    }
}