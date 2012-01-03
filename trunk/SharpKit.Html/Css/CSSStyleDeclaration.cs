//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class CSSStyleDeclaration
{

	// CSSStyleDeclaration
	public JsString cssText {get; set; }
	public int length {get; private set; }
	[JsProperty(NativeIndexer = true)]
	public JsString this[int index] {get { return default(JsString); } }
	public JsString getPropertyValue(string property) { return default(JsString); }
	public JsString getPropertyPriority(string property) { return default(JsString); }
	public void setProperty(string property, string value) {}
	public void setProperty(string property, string value, string priority) {}
	public JsString removeProperty(string property) { return default(JsString); }
	public CSSStyleDeclarationValue values {get; private set; }
	public CSSRule parentRule {get; private set; }
	public JsString azimuth {get; set; }
	public JsString background {get; set; }
	public JsString backgroundAttachment {get; set; }
	public JsString backgroundColor {get; set; }
	public JsString backgroundImage {get; set; }
	public JsString backgroundPosition {get; set; }
	public JsString backgroundRepeat {get; set; }
	public JsString border {get; set; }
	public JsString borderCollapse {get; set; }
	public JsString borderColor {get; set; }
	public JsString borderSpacing {get; set; }
	public JsString borderStyle {get; set; }
	public JsString borderTop {get; set; }
	public JsString borderRight {get; set; }
	public JsString borderBottom {get; set; }
	public JsString borderLeft {get; set; }
	public JsString borderTopColor {get; set; }
	public JsString borderRightColor {get; set; }
	public JsString borderBottomColor {get; set; }
	public JsString borderLeftColor {get; set; }
	public JsString borderTopStyle {get; set; }
	public JsString borderRightStyle {get; set; }
	public JsString borderBottomStyle {get; set; }
	public JsString borderLeftStyle {get; set; }
	public JsString borderTopWidth {get; set; }
	public JsString borderRightWidth {get; set; }
	public JsString borderBottomWidth {get; set; }
	public JsString borderLeftWidth {get; set; }
	public JsString borderWidth {get; set; }
	public JsString bottom {get; set; }
	public JsString captionSide {get; set; }
	public JsString clear {get; set; }
	public JsString clip {get; set; }
	public JsString color {get; set; }
	public JsString content {get; set; }
	public JsString counterIncrement {get; set; }
	public JsString counterReset {get; set; }
	public JsString cue {get; set; }
	public JsString cueAfter {get; set; }
	public JsString cueBefore {get; set; }
	public JsString cursor {get; set; }
	public JsString direction {get; set; }
	public JsString display {get; set; }
	public JsString elevation {get; set; }
	public JsString emptyCells {get; set; }
	public JsString cssFloat {get; set; }
	public JsString font {get; set; }
	public JsString fontFamily {get; set; }
	public JsString fontSize {get; set; }
	public JsString fontSizeAdjust {get; set; }
	public JsString fontStretch {get; set; }
	public JsString fontStyle {get; set; }
	public JsString fontVariant {get; set; }
	public JsString fontWeight {get; set; }
	public JsString height {get; set; }
	public JsString left {get; set; }
	public JsString letterSpacing {get; set; }
	public JsString lineHeight {get; set; }
	public JsString listStyle {get; set; }
	public JsString listStyleImage {get; set; }
	public JsString listStylePosition {get; set; }
	public JsString listStyleType {get; set; }
	public JsString margin {get; set; }
	public JsString marginTop {get; set; }
	public JsString marginRight {get; set; }
	public JsString marginBottom {get; set; }
	public JsString marginLeft {get; set; }
	public JsString markerOffset {get; set; }
	public JsString marks {get; set; }
	public JsString maxHeight {get; set; }
	public JsString maxWidth {get; set; }
	public JsString minHeight {get; set; }
	public JsString minWidth {get; set; }
    public JsString opacity { get; set; }
	public JsString orphans {get; set; }
	public JsString outline {get; set; }
	public JsString outlineColor {get; set; }
	public JsString outlineStyle {get; set; }
	public JsString outlineWidth {get; set; }
	public JsString overflow {get; set; }
	public JsString padding {get; set; }
	public JsString paddingTop {get; set; }
	public JsString paddingRight {get; set; }
	public JsString paddingBottom {get; set; }
	public JsString paddingLeft {get; set; }
	public JsString page {get; set; }
	public JsString pageBreakAfter {get; set; }
	public JsString pageBreakBefore {get; set; }
	public JsString pageBreakInside {get; set; }
	public JsString pause {get; set; }
	public JsString pauseAfter {get; set; }
	public JsString pauseBefore {get; set; }
	public JsString pitch {get; set; }
	public JsString pitchRange {get; set; }
	public JsString playDuring {get; set; }
	public JsString position {get; set; }
	public JsString quotes {get; set; }
	public JsString richness {get; set; }
	public JsString right {get; set; }
	public JsString size {get; set; }
	public JsString speak {get; set; }
	public JsString speakHeader {get; set; }
	public JsString speakNumeral {get; set; }
	public JsString speakPunctuation {get; set; }
	public JsString speechRate {get; set; }
	public JsString stress {get; set; }
	public JsString tableLayout {get; set; }
	public JsString textAlign {get; set; }
	public JsString textDecoration {get; set; }
	public JsString textIndent {get; set; }
	public JsString textShadow {get; set; }
	public JsString textTransform {get; set; }
	public JsString top {get; set; }
	public JsString unicodeBidi {get; set; }
	public JsString verticalAlign {get; set; }
	public JsString visibility {get; set; }
	public JsString voiceFamily {get; set; }
	public JsString volume {get; set; }
	public JsString whiteSpace {get; set; }
	public JsString widows {get; set; }
	public JsString width {get; set; }
	public JsString wordSpacing {get; set; }
	public JsString zIndex {get; set; }
}

}