//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.events
{

using SharpKit.JavaScript;
using DOMException = org.w3c.dom.DOMException;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class EventTarget
{

	// EventTarget
	public void addEventListener(string type, EventListener listener, bool useCapture) {}
	public void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public bool dispatchEvent(Event evt) { return default(bool); }
}

}