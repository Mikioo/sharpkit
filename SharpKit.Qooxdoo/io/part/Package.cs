// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.io.part
{
    /// <summary>
	/// <para>The Package wraps a list of related script URLs, which are required by one
	/// or more parts.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.io.part.Package", OmitOptionalParameters = true, Export = false)]
    public partial class Package 
    {
		#region Methods

		public Package() { throw new NotImplementedException(); }

		/// <param name="urls">A list of script URLs</param>
		/// <param name="id">Unique package hash key</param>
		/// <param name="loaded">Whether the package is already loaded</param>
		public Package(string urls, object id, bool loaded = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Executes the stored closure. This is only relevant if a
		/// <see cref="qx.io.part.ClosurePart"/> is used.</para>
		/// </summary>
		[JsMethod(Name = "execute")]
		public void Execute() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the package ID.</para>
		/// </summary>
		/// <returns>The package id</returns>
		[JsMethod(Name = "getId")]
		public string GetId() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the ready state of the package. The value is one of
		/// <list type="bullet">
		/// <item>
		/// initialized: The package is initialized. The <see cref="Load"/>
		/// method has not yet been called
		/// </item>
		/// <item>loading: The package is still loading.</item>
		/// <item>complete: The package has been loaded successfully</item>
		/// <item>cached: The package is loaded but is not executed
		/// (for closure parts)</item>
		/// </item></para>
		/// </summary>
		/// <returns>The ready state.</returns>
		[JsMethod(Name = "getReadyState")]
		public string GetReadyState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Load the part&#8217;s script URLs in the correct order.</para>
		/// </summary>
		/// <param name="notifyPackageResult">The callback if all scripts are done loading in this package.</param>
		/// <param name="self">The context of the callback.</param>
		[JsMethod(Name = "load")]
		public void Load(Action<object> notifyPackageResult, object self) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Load method if the package loads a closure. This is only relevant if a
		/// <see cref="qx.io.part.ClosurePart"/> is used.</para>
		/// </summary>
		/// <param name="notifyPackageResult">The callback if all scripts are done loading in this package.</param>
		/// <param name="self">The context of the callback.</param>
		[JsMethod(Name = "loadClosure")]
		public void LoadClosure(Action<object> notifyPackageResult, object self) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Method for storing the closure for this package. This is only relevant
		/// if a <see cref="qx.io.part.ClosurePart"/> is used.</para>
		/// </summary>
		/// <param name="closure">The code of this package wrapped in a closure.</param>
		[JsMethod(Name = "saveClosure")]
		public void SaveClosure(Action<object> closure) { throw new NotImplementedException(); }

		#endregion Methods
    }
}