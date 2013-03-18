// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.element
{
    /// <summary>
	/// <para>This is a simple handle, which will be returned when an animation is
	/// started using the <see cref="qx.bom.element.Animation.Animate"/> method. It
	/// basically controls the animation.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.element.AnimationHandle", OmitOptionalParameters = true, Export = false)]
    public partial class AnimationHandle : qx.eventx.Emitter
    {
		#region Events

		/// <summary>
		/// <para>Fired when the animation started via <see cref="qx.bom.element.Animation"/> has
		/// ended.</para>
		/// </summary>
		public event Action<qx.html.Element> OnEnd;

		/// <summary>
		/// <para>Fired on every iteration of the animation.</para>
		/// </summary>
		public event Action<qx.html.Element> OnIteration;

		/// <summary>
		/// <para>Fired when the animation started via <see cref="qx.bom.element.Animation"/>.</para>
		/// </summary>
		public event Action<qx.html.Element> OnStart;

		#endregion Events

		#region Methods

		public AnimationHandle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Accessor of the ended state.</para>
		/// </summary>
		/// <returns>true, if the animations has ended.</returns>
		[JsMethod(Name = "isEnded")]
		public bool IsEnded() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Accessor of the paused state.</para>
		/// </summary>
		/// <returns>true, if the animations is paused.</returns>
		[JsMethod(Name = "isPaused")]
		public bool IsPaused() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Accessor of the playing state.</para>
		/// </summary>
		/// <returns>true, if the animations is playing.</returns>
		[JsMethod(Name = "isPlaying")]
		public bool IsPlaying() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Pauses the animation, if running. If not running, it will be ignored.</para>
		/// </summary>
		[JsMethod(Name = "pause")]
		public void Pause() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resumes an animation. This does not start the animation once it has ended.
		/// You need to create start a new Animation if you want to restart the animation.</para>
		/// </summary>
		[JsMethod(Name = "play")]
		public void Play() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Stops the animation if running.</para>
		/// </summary>
		[JsMethod(Name = "stop")]
		public void Stop() { throw new NotImplementedException(); }

		#endregion Methods
    }
}