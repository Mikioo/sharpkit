//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class WorkerNavigator
{

	// WorkerNavigator

	// NavigatorID
	public JsString appName {get; private set; }
	public JsString appVersion {get; private set; }
	public JsString platform {get; private set; }
	public JsString userAgent {get; private set; }

	// NavigatorOnLine
	public bool onLine {get; private set; }
}

}