//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class Geolocation
{

	// Geolocation
	public void getCurrentPosition(PositionCallback successCallback) {}
	public void getCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback) {}
	public void getCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback, PositionOptions options) {}
	public int watchPosition(PositionCallback successCallback) { return default(int); }
	public int watchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback) { return default(int); }
	public int watchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback, PositionOptions options) { return default(int); }
	public void clearWatch(int watchId) {}
}

}