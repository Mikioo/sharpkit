//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class HTMLTableElement : HTMLElement
{

	// HTMLTableElement
	public HTMLTableCaptionElement caption {get;set;}
	public HTMLElement createCaption() { return default(HTMLElement); }
	public void deleteCaption() {}
	public HTMLTableSectionElement tHead {get;set;}
	public HTMLElement createTHead() { return default(HTMLElement); }
	public void deleteTHead() {}
	public HTMLTableSectionElement tFoot {get;set;}
	public HTMLElement createTFoot() { return default(HTMLElement); }
	public void deleteTFoot() {}
	public HTMLCollection tBodies {get;private set;}
	public HTMLElement createTBody() { return default(HTMLElement); }
	public HTMLCollection rows {get;private set;}
	public HTMLElement insertRow() { return default(HTMLElement); }
	public HTMLElement insertRow(int index) { return default(HTMLElement); }
	public void deleteRow(int index) {}
	public string summary {get;set;}

	// HTMLTableElement-31
	public string align {get;set;}
	public string bgColor {get;set;}
	public string border {get;set;}
	public string cellPadding {get;set;}
	public string cellSpacing {get;set;}
	public string frame {get;set;}
	public string rules {get;set;}
	public string width {get;set;}
}

}