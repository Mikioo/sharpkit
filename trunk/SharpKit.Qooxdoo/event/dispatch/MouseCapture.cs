// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.dispatch
{
    /// <summary>
	/// <para>Implementation of the Internet Explorer specific event capturing mode for
	/// mouse events http://msdn2.microsoft.com/en-us/library/ms536742.aspx.</para>
	/// <para>This class is used internally by <see cref="qx.event.Manager"/> to do mouse event
	/// capturing.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.dispatch.MouseCapture", OmitOptionalParameters = true, Export = false)]
    public partial class MouseCapture : qx.eventx.dispatch.AbstractBubbling
    {
		#region Methods

		public MouseCapture() { throw new NotImplementedException(); }

		/// <param name="manager">Event manager for the window to use</param>
		/// <param name="registration">The event registration to use</param>
		public MouseCapture(qx.eventx.Manager manager, qx.eventx.Registration registration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the given element as target for event</para>
		/// </summary>
		/// <param name="element">The element which should capture the mouse events.</param>
		/// <param name="containerCapture">If true all events originating in the container are captured. IF false events originating in the container are not captured.</param>
		[JsMethod(Name = "activateCapture")]
		public void ActivateCapture(qx.html.Element element, bool containerCapture = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the dispatcher is responsible for the this event.</para>
		/// </summary>
		/// <param name="target">The event dispatch target</param>
		/// <param name="eventx">The event object</param>
		/// <param name="type">the event type</param>
		/// <returns>Whether the event dispatcher is responsible for the this event</returns>
		[JsMethod(Name = "canDispatchEvent")]
		public bool CanDispatchEvent(object target, qx.eventx.type.Event eventx, string type) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Dispatch an event on this object</para>
		/// </summary>
		/// <param name="evt">event to dispatch</param>
		/// <returns>Whether the event default was prevented or not. Returns true, when the event was NOT prevented.</returns>
		[JsMethod(Name = "dispatchEvent")]
		public bool DispatchEvent(qx.eventx.type.Event evt) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the element currently capturing events.</para>
		/// </summary>
		/// <returns>The current capture element. This value may be null.</returns>
		[JsMethod(Name = "getCaptureElement")]
		public qx.html.Element GetCaptureElement() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>If the browser supports native mouse capturing, removes mouse capture
		/// from the object in the current document.</para>
		/// </summary>
		/// <param name="element">The DOM element to release the capture for</param>
		[JsMethod(Name = "nativeReleaseCapture")]
		public void NativeReleaseCapture(qx.html.Element element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>If the browser supports native mouse capturing, sets the mouse capture to
		/// the object that belongs to the current document.</para>
		/// </summary>
		/// <param name="element">The capture DOM element</param>
		/// <param name="containerCapture">If true all events originating in the container are captured. If false events originating in the container are not captured.</param>
		[JsMethod(Name = "nativeSetCapture")]
		public void NativeSetCapture(qx.html.Element element, bool containerCapture = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Stop capturing of mouse events.</para>
		/// </summary>
		[JsMethod(Name = "releaseCapture")]
		public void ReleaseCapture() { throw new NotImplementedException(); }

		#endregion Methods
    }
}