//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form
namespace Ext.form
{
    #region Labelable
    /// <summary>
    /// <p>A mixin which allows a component to be configured and decorated with a label and/or error message as is
    /// common for form fields. This is used by e.g. <see cref="Ext.form.field.Base">Ext.form.field.Base</see> and <see cref="Ext.form.FieldContainer">Ext.form.FieldContainer</see>
    /// to let them be managed by the Field layout.</p>
    /// <p>NOTE: This mixin is mainly for internal library use and most users should not need to use it directly. It
    /// is more likely you will want to use one of the component classes that import this mixin, such as
    /// <see cref="Ext.form.field.Base">Ext.form.field.Base</see> or <see cref="Ext.form.FieldContainer">Ext.form.FieldContainer</see>.</p>
    /// <p>Use of this mixin does not make a component a field in the logical sense, meaning it does not provide any
    /// logic or state related to values or validation; that is handled by the related <see cref="Ext.form.field.Field">Ext.form.field.Field</see>
    /// mixin. These two mixins may be used separately (for example <see cref="Ext.form.FieldContainer">Ext.form.FieldContainer</see> is Labelable but not a
    /// Field), or in combination (for example <see cref="Ext.form.field.Base">Ext.form.field.Base</see> implements both and has logic for connecting the
    /// two.)</p>
    /// <p>Component classes which use this mixin should use the Field layout
    /// or a derivation thereof to properly size and position the label and message according to the component config.
    /// They must also call the <see cref="Ext.form.Labelable.initLabelable">initLabelable</see> method during component initialization to ensure the mixin gets
    /// set up correctly.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial interface Labelable
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        JsString @className{get;set;}
        /// <summary>
        /// The div Element wrapping the component's contents. Only available after the component has been rendered.
        /// </summary>
        Ext.dom.Element bodyEl{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        JsObject configMap{get;set;}
        /// <summary>
        /// The div Element that will contain the component's error message(s). Note that depending on the configured
        /// msgTarget, this element may be hidden in favor of some other form of presentation, but will always
        /// be present in the DOM for use by assistive technologies.
        /// </summary>
        Ext.dom.Element errorEl{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        JsObject initConfigMap{get;set;}
        /// <summary>
        /// Flag denoting that this object is labelable as a field. Always true.
        /// Defaults to: <c>true</c>
        /// </summary>
        bool isFieldLabelable{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        bool isInstance{get;set;}
        /// <summary>
        /// The &lt;TD&gt; Element which contains the label Element for this component. Only available after the component has been rendered.
        /// </summary>
        Ext.dom.Element labelCell{get;set;}
        /// <summary>
        /// The label Element for this component. Only available after the component has been rendered.
        /// </summary>
        Ext.dom.Element labelEl{get;set;}
        /// <summary>
        /// Tells the layout system that the height can be measured immediately because the width does not need setting.
        /// Defaults to: <c>true</c>
        /// </summary>
        bool noWrap{get;set;}
        /// <summary>
        /// Get the reference to the current class from which this object was instantiated. Unlike statics,
        /// this.self is scope-dependent and it's meant to be used for dynamic inheritance. See statics
        /// for a detailed comparison
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// alert(this.self.speciesName); // dependent on 'this'
        /// },
        /// clone: function() {
        /// return new this.self();
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'         // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// }
        /// });
        /// var cat = new My.Cat();                     // alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard();     // alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));             // alerts 'My.SnowLeopard'
        /// </code>
        /// </summary>
        Class self{get;set;}
        /// <summary>
        /// Gets the active error message for this component, if any. This does not trigger validation on its own, it merely
        /// returns any message that the component may already hold.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The active error message on the component; if there is no error, an empty string is returned.</p>
        /// </div>
        /// </returns>
        JsString getActiveError();
        /// <summary>
        /// Gets an Array of any active error messages currently applied to the field. This does not trigger validation on
        /// its own, it merely returns any messages that the component may already hold.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see>[]</span><div><p>The active error messages on the component; if there are no errors, an empty Array is
        /// returned.</p>
        /// </div>
        /// </returns>
        JsString[] getActiveErrors();
        /// <summary>
        /// Calculates the colspan value for the body cell - the cell which contains the input field.
        /// The field table structure contains 4 columns:
        /// </summary>
        void getBodyColspan();
        /// <summary>
        /// Returns the label for the field. Defaults to simply returning the fieldLabel config. Can be overridden
        /// to provide a custom generated label.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The configured field label, or empty string if not defined</p>
        /// </div>
        /// </returns>
        JsString getFieldLabel();
        /// <summary>
        /// Get the input id, if any, for this component. This is used as the "for" attribute on the label element.
        /// Implementing subclasses may also use this as e.g. the id for their own input element.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The input id</p>
        /// </div>
        /// </returns>
        JsString getInputId();
        /// <summary>
        /// Gets any label styling for the labelEl
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The label styling</p>
        /// </div>
        /// </returns>
        JsString getLabelStyle();
        /// <summary>
        /// Generates the arguments for the field decorations rendering template.
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The template arguments</p>
        /// </div>
        /// </returns>
        object getLabelableRenderData();
        /// <summary>
        /// Gets the markup to be inserted into the outer template's bodyEl. Defaults to empty string, should be implemented
        /// by classes including this mixin as needed.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The markup to be inserted</p>
        /// </div>
        /// </returns>
        JsString getSubTplMarkup();
        /// <summary>
        /// Tells whether the field currently has an active error message. This does not trigger validation on its own, it
        /// merely looks for any message that the component may already hold.
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        bool hasActiveError();
        /// <summary>
        /// Checks if the field has a visible label
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the field has a visible label</p>
        /// </div>
        /// </returns>
        bool hasVisibleLabel();
        /// <summary>
        /// Performs initialization of this mixin. Component classes using this mixin should call this method during their
        /// own initialization.
        /// </summary>
        void initLabelable();
        /// <summary>
        /// Updates the rendered DOM to match the current activeError. This only updates the content and
        /// attributes, you'll have to call doComponentLayout to actually update the display.
        /// </summary>
        void renderActiveError();
        /// <summary>
        /// Sets the active error message to the given string. This replaces the entire error message contents with the given
        /// string. Also see setActiveErrors which accepts an Array of messages and formats them according to the
        /// activeErrorsTpl. Note that this only updates the error message element's text and attributes, you'll
        /// have to call doComponentLayout to actually update the field's layout to match. If the field extends Ext.form.field.Base you should call markInvalid instead.
        /// </summary>
        /// <param name="msg"><p>The error message</p>
        /// </param>
        void setActiveError(JsString msg);
        /// <summary>
        /// Set the active error message to an Array of error messages. The messages are formatted into a single message
        /// string using the activeErrorsTpl. Also see setActiveError which allows setting the entire error
        /// contents with a single string. Note that this only updates the error message element's text and attributes,
        /// you'll have to call doComponentLayout to actually update the field's layout to match. If the field extends
        /// Ext.form.field.Base you should call markInvalid instead.
        /// </summary>
        /// <param name="errors"><p>The error messages</p>
        /// </param>
        void setActiveErrors(JsArray<String> errors);
        /// <summary>
        /// Applies a set of default configuration values to this Labelable instance. For each of the properties in the given
        /// object, check if this component hasOwnProperty that config; if not then it's inheriting a default value from its
        /// prototype and we should apply the default value.
        /// </summary>
        /// <param name="defaults"><p>The defaults to apply to the object.</p>
        /// </param>
        void setFieldDefaults(object defaults);
        /// <summary>
        /// Set the label of this field.
        /// </summary>
        /// <param name="label"><p>The new label. The <see cref="Ext.form.LabelableConfig.labelSeparator">labelSeparator</see> will be automatically appended to the label
        /// string.</p>
        /// </param>
        void setFieldLabel(JsString label);
        /// <summary>
        /// Returns the trimmed label by slicing off the label separator character. Can be overridden.
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The trimmed field label, or empty string if not defined</p>
        /// </div>
        /// </returns>
        JsString trimLabelSeparator();
        /// <summary>
        /// Clears the active error message(s). Note that this only clears the error message element's text and attributes,
        /// you'll have to call doComponentLayout to actually update the field's layout to match. If the field extends Ext.form.field.Base you should call clearInvalid instead.
        /// </summary>
        void unsetActiveError();
    }
    #endregion
    #region LabelableConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LabelableConfig : Ext.BaseConfig
    {
        /// <summary>
        /// If specified, then the component will be displayed with this value as its active error when first rendered. Use
        /// setActiveError or unsetActiveError to change it after component creation.
        /// </summary>
        public JsString activeError;
        /// <summary>
        /// The template used to format the Array of error messages passed to setActiveErrors into a single HTML
        /// string. By default this renders each message as an item in an unordered list.
        /// Defaults to: <c>[&quot;&lt;tpl if=&quot;errors &amp;&amp; errors.length&quot;&gt;&quot;, &quot;&lt;ul&gt;&lt;tpl for=&quot;errors&quot;&gt;&lt;li&gt;{.}&lt;/li&gt;&lt;/tpl&gt;&lt;/ul&gt;&quot;, &quot;&lt;/tpl&gt;&quot;]</c>
        /// </summary>
        public object activeErrorsTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// at the end of the input containing element. If an XTemplate is used, the component's render data
        /// serves as the context.
        /// </summary>
        public object afterBodyEl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// after the label text. If an XTemplate is used, the component's render data
        /// serves as the context.
        /// </summary>
        public object afterLabelTextTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// after the label element. If an XTemplate is used, the component's render data
        /// serves as the context.
        /// </summary>
        public object afterLabelTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// after the subTpl markup. If an XTemplate is used, the
        /// component's render data serves as the context.
        /// </summary>
        public object afterSubTpl;
        /// <summary>
        /// Whether to adjust the component's body area to make room for 'side' or 'under' error messages.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool autoFitErrors;
        /// <summary>
        /// The CSS class to be applied to the body content element.
        /// Defaults to: <c>&quot;x-form-item-body&quot;</c>
        /// </summary>
        public JsString baseBodyCls;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// at the beginning of the input containing element. If an XTemplate is used, the component's render data
        /// serves as the context.
        /// </summary>
        public object beforeBodyEl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// before the label text. If an XTemplate is used, the component's render data
        /// serves as the context.
        /// </summary>
        public object beforeLabelTextTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// before the label element. If an XTemplate is used, the component's render data
        /// serves as the context.
        /// </summary>
        public object beforeLabelTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// before the subTpl markup. If an XTemplate is used, the
        /// component's render data serves as the context.
        /// </summary>
        public object beforeSubTpl;
        /// <summary>
        /// The CSS class to be applied to the special clearing div rendered directly after the field contents wrapper to
        /// provide field clearing.
        /// Defaults to: <c>&quot;x-clear&quot;</c>
        /// </summary>
        public JsString clearCls;
        /// <summary>
        /// The CSS class to be applied to the error message element.
        /// Defaults to: <c>&quot;x-form-error-msg&quot;</c>
        /// </summary>
        public JsString errorMsgCls;
        /// <summary>
        /// An extra CSS class to be applied to the body content element in addition to baseBodyCls.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString fieldBodyCls;
        /// <summary>
        /// The label for the field. It gets appended with the labelSeparator, and its position and sizing is
        /// determined by the labelAlign, labelWidth, and labelPad configs.
        /// </summary>
        public JsString fieldLabel;
        /// <summary>
        /// A CSS class to be applied to the outermost element to denote that it is participating in the form field layout.
        /// Defaults to: <c>&quot;x-form-item&quot;</c>
        /// </summary>
        public JsString formItemCls;
        /// <summary>
        /// When set to true, the label element (fieldLabel and labelSeparator) will be automatically
        /// hidden if the fieldLabel is empty. Setting this to false will cause the empty label element to be
        /// rendered and space to be reserved for it; this is useful if you want a field without a label to line up with
        /// other labeled fields in the same form.
        /// If you wish to unconditionall hide the label even if a non-empty fieldLabel is configured, then set the
        /// <see cref="Ext.form.LabelableConfig.hideLabel">hideLabel</see> config to true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool hideEmptyLabel;
        /// <summary>
        /// Set to true to completely hide the label element (fieldLabel and labelSeparator). Also see
        /// hideEmptyLabel, which controls whether space will be reserved for an empty fieldLabel.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool hideLabel;
        /// <summary>
        /// The CSS class to use when marking the component invalid.
        /// Defaults to: <c>&quot;x-form-invalid&quot;</c>
        /// </summary>
        public JsString invalidCls;
        /// <summary>
        /// Controls the position and alignment of the fieldLabel. Valid values are:
        /// <li>"left" (the default) - The label is positioned to the left of the field, with its text aligned to the left.
        /// Its width is determined by the <see cref="Ext.form.LabelableConfig.labelWidth">labelWidth</see> config.</li>
        /// <li>"top" - The label is positioned above the field.</li>
        /// <li>"right" - The label is positioned to the left of the field, with its text aligned to the right.
        /// Its width is determined by the <see cref="Ext.form.LabelableConfig.labelWidth">labelWidth</see> config.</li>
        /// Defaults to: <c>&quot;left&quot;</c>
        /// </summary>
        public JsString labelAlign;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// inside the label element (as attributes). If an XTemplate is used, the component's
        /// render data serves as the context.
        /// </summary>
        public object labelAttrTpl;
        /// <summary>
        /// The CSS class to be applied to the label element. This (single) CSS class is used to formulate the renderSelector
        /// and drives the field layout where it is concatenated with a hyphen ('-') and labelAlign. To add
        /// additional classes, use labelClsExtra.
        /// Defaults to: <c>&quot;x-form-item-label&quot;</c>
        /// </summary>
        public JsString labelCls;
        /// <summary>
        /// An optional string of one or more additional CSS classes to add to the label element. Defaults to empty.
        /// </summary>
        public JsString labelClsExtra;
        /// <summary>
        /// The amount of space in pixels between the fieldLabel and the input field.
        /// Defaults to: <c>5</c>
        /// </summary>
        public JsNumber labelPad;
        /// <summary>
        /// Character(s) to be inserted at the end of the label text.
        /// Set to empty string to hide the separator completely.
        /// Defaults to: <c>&quot;:&quot;</c>
        /// </summary>
        public JsString labelSeparator;
        /// <summary>
        /// A CSS style specification string to apply directly to this field's label.
        /// </summary>
        public JsString labelStyle;
        /// <summary>
        /// The width of the fieldLabel in pixels. Only applicable if the labelAlign is set to "left" or
        /// "right".
        /// Defaults to: <c>100</c>
        /// </summary>
        public JsNumber labelWidth;
        /// <summary>
        /// The rendering template for the field decorations. Component classes using this mixin
        /// should include logic to use this as their renderTpl,
        /// and implement the getSubTplMarkup method to generate the field body content.
        /// The structure of a field is a table as follows:
        /// If <c>labelAlign: 'left',</c>msgTarget: 'side'`
        /// <code> +----------------------+----------------------+-------------+
        /// | Label:               | InputField           | sideErrorEl |
        /// +----------------------+----------------------+-------------+
        /// </code>
        /// If <c>labelAlign: 'left',</c>msgTarget: 'under'`
        /// <code> +----------------------+------------------------------------+
        /// | Label:               | InputField      (colspan=2)        |
        /// |                      | underErrorEl                       |
        /// +----------------------+------------------------------------+
        /// </code>
        /// If <c>labelAlign: 'top',</c>msgTarget: 'side'`
        /// <code> +---------------------------------------------+-------------+
        /// | label                                       |             |
        /// | InputField                                  | sideErrorEl |
        /// +---------------------------------------------+-------------+
        /// </code>
        /// If <c>labelAlign: 'top',</c>msgTarget: 'under'`
        /// <code> +-----------------------------------------------------------+
        /// | label                                                     |
        /// | InputField                      (colspan=2)               |
        /// | underErrorEl                                              |
        /// +-----------------------------------------------------------+
        /// </code>
        /// The total columns always the same for fields with each setting of <see cref="Ext.form.LabelableConfig.labelAlign">labelAlign</see> because when
        /// rendered into a <see cref="Ext.layout.container.Form">Ext.layout.container.Form</see> layout, just the <c>TR</c> of the table
        /// will be placed into the form's main <c>TABLE</c>, and the columns of all the siblings
        /// must match so that they all line up. In a <see cref="Ext.layout.container.Form">Ext.layout.container.Form</see> layout, different
        /// settings of <see cref="Ext.form.LabelableConfig.labelAlign">labelAlign</see> are not supported because of the incompatible column structure.
        /// When the triggerCell or side error cell are hidden or shown, the input cell's colspan
        /// is recalculated to maintain the correct 3 visible column count.
        /// Defaults to: <c>[&quot;&lt;tr id=&quot;{id}-inputRow&quot; &lt;tpl if=&quot;inFormLayout&quot;&gt;id=&quot;{id}&quot;&lt;/tpl&gt;&gt;&quot;, &quot;&lt;tpl if=&quot;labelOnLeft&quot;&gt;&quot;, &quot;&lt;td id=&quot;{id}-labelCell&quot; style=&quot;{labelCellStyle}&quot; {labelCellAttrs}&gt;&quot;, &quot;{beforeLabelTpl}&quot;, &quot;&lt;label id=&quot;{id}-labelEl&quot; {labelAttrTpl}&lt;tpl if=&quot;inputId&quot;&gt; for=&quot;{inputId}&quot;&lt;/tpl&gt; class=&quot;{labelCls}&quot;&quot;, &quot;&lt;tpl if=&quot;labelStyle&quot;&gt; style=&quot;{labelStyle}&quot;&lt;/tpl&gt;&gt;&quot;, &quot;{beforeLabelTextTpl}&quot;, &quot;&lt;tpl if=&quot;fieldLabel&quot;&gt;{fieldLabel}{labelSeparator}&lt;/tpl&gt;&quot;, &quot;{afterLabelTextTpl}&quot;, &quot;&lt;/label&gt;&quot;, &quot;{afterLabelTpl}&quot;, &quot;&lt;/td&gt;&quot;, &quot;&lt;/tpl&gt;&quot;, &quot;&lt;td class=&quot;{baseBodyCls} {fieldBodyCls}&quot; id=&quot;{id}-bodyEl&quot; colspan=&quot;{bodyColspan}&quot; role=&quot;presentation&quot;&gt;&quot;, &quot;{beforeBodyEl}&quot;, &quot;&lt;tpl if=&quot;labelAlign==\'top\'&quot;&gt;&quot;, &quot;{beforeLabelTpl}&quot;, &quot;&lt;div id=&quot;{id}-labelCell&quot; style=&quot;{labelCellStyle}&quot;&gt;&quot;, &quot;&lt;label id=&quot;{id}-labelEl&quot; {labelAttrTpl}&lt;tpl if=&quot;inputId&quot;&gt; for=&quot;{inputId}&quot;&lt;/tpl&gt; class=&quot;{labelCls}&quot;&quot;, &quot;&lt;tpl if=&quot;labelStyle&quot;&gt; style=&quot;{labelStyle}&quot;&lt;/tpl&gt;&gt;&quot;, &quot;{beforeLabelTextTpl}&quot;, &quot;&lt;tpl if=&quot;fieldLabel&quot;&gt;{fieldLabel}{labelSeparator}&lt;/tpl&gt;&quot;, &quot;{afterLabelTextTpl}&quot;, &quot;&lt;/label&gt;&quot;, &quot;&lt;/div&gt;&quot;, &quot;{afterLabelTpl}&quot;, &quot;&lt;/tpl&gt;&quot;, &quot;{beforeSubTpl}&quot;, &quot;{[values.$comp.getSubTplMarkup()]}&quot;, &quot;{afterSubTpl}&quot;, &quot;&lt;tpl if=&quot;msgTarget===\'side\'&quot;&gt;&quot;, &quot;{afterBodyEl}&quot;, &quot;&lt;/td&gt;&quot;, &quot;&lt;td id=&quot;{id}-sideErrorCell&quot; vAlign=&quot;{[values.labelAlign===\'top\' &amp;&amp; !values.hideLabel ? \'bottom\' : \'middle\']}&quot; style=&quot;{[values.autoFitErrors ? \'display:none\' : \'\']}&quot; width=&quot;{errorIconWidth}&quot;&gt;&quot;, &quot;&lt;div id=&quot;{id}-errorEl&quot; class=&quot;{errorMsgCls}&quot; style=&quot;display:none;width:{errorIconWidth}px&quot;&gt;&lt;/div&gt;&quot;, &quot;&lt;/td&gt;&quot;, &quot;&lt;tpl elseif=&quot;msgTarget==\'under\'&quot;&gt;&quot;, &quot;&lt;div id=&quot;{id}-errorEl&quot; class=&quot;{errorMsgClass}&quot; colspan=&quot;2&quot; style=&quot;display:none&quot;&gt;&lt;/div&gt;&quot;, &quot;{afterBodyEl}&quot;, &quot;&lt;/td&gt;&quot;, &quot;&lt;/tpl&gt;&quot;, &quot;&lt;/tr&gt;&quot;, {disableFormats: true}]</c>
        /// </summary>
        public object labelableRenderTpl;
        /// <summary>
        /// The location where the error message text should display. Must be one of the following values:
        /// <li><p><c>qtip</c> Display a quick tip containing the message when the user hovers over the field.
        /// This is the default.</p>
        /// <p><strong><see cref="Ext.tip.QuickTipManager.init">Ext.tip.QuickTipManager.init</see> must have been called for this setting to work.</strong></p></li>
        /// <li><p><c>title</c> Display the message in a default browser title attribute popup.</p></li>
        /// <li><c>under</c> Add a block div beneath the field containing the error message.</li>
        /// <li><c>side</c> Add an error icon to the right of the field, displaying the message in a popup on hover.</li>
        /// <li><c>none</c> Don't display any error message. This might be useful if you are implementing custom error display.</li>
        /// <li><c>[element id]</c> Add the error message directly to the innerHTML of the specified element.</li>
        /// Defaults to: <c>&quot;qtip&quot;</c>
        /// </summary>
        public JsString msgTarget;
        /// <summary>
        /// true to disable displaying any error message set on this object.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool preventMark;
        public LabelableConfig(params object[] args){}
    }
    #endregion
    #region LabelableEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LabelableEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when the active error message is changed via setActiveError.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="error"><p>The active error message</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void errorchange(Labelable @this, JsString error, object eOpts){}
        public LabelableEvents(params object[] args){}
    }
    #endregion
}
#endregion
