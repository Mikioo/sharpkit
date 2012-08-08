﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;


namespace SharpKit.jQuery
{
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class KendoUIWebExtensions
    {

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoAutoComplete(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoAutoComplete(this jQuery query, AutoCompleteConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoCalendar(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoCalendar(this jQuery query, ComboBoxConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoComboBox(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoComboBox(this jQuery query, CalendarConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDatePicker(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDatePicker(this jQuery query, DatePickerConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDateTimePicker(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDateTimePicker(this jQuery query, DateTimePickerConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDropDownList(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDropDownList(this jQuery query, DropDownListConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoEditor(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoEditor(this jQuery query, EditorConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoGrid(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoGrid(this jQuery query, GridConfiguration configuration) { return null; }
    }

}

namespace SharpKit.KendoUI.Web
{

    public class AutoComplete
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        ///autocomplete.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var autocomplete = $("#autocomplete").data("kendoAutoComplete");
        /// // get the dataItem corresponding to the passed index.
        ///var dataItem = autocomplete.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enable/Disable the autocomplete widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI AutoComplete
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // re-render the items in drop-down list.
        ///autocomplete.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Filters dataSource using the provided parameter and rebinds drop-down list.
        /// </summary>
        /// <param name="word">The filter value.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // Searches for item which has "Inception" in the name.
        ///autocomplete.search("Inception");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the text of the autocomplete.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // selects by jQuery object
        ///autocomplete.select(autocomplete.ul.children().eq(0));
        ///</code>
        ///</example>
        public void select(jQuery.jQuery li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"
        /// <summary>
        /// Selects drop-down list item and sets the text of the autocomplete.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // selects by jQuery object
        ///autocomplete.select(autocomplete.ul.children().eq(0));
        ///</code>
        ///</example>
        public void select(object li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"

        /// <summary>
        /// Forces a suggestion onto the text of the AutoComplete.
        /// </summary>
        /// <param name="value">Characters to force a suggestion.</param>
        ///<example>
        ///usage
        ///<code>
        /// // note that this suggest is not the same as the configuration method
        /// // suggest which enables/disables auto suggesting for the AutoComplete
        /// //
        /// // get a referenence to the Kendo UI AutoComplete
        ///var autoComplete = $("#autoComplete").data("kendoAutoComplete");
        /// // force a suggestion to the item with the name "Inception"
        ///autoComplete.suggest("Inception");
        ///</code>
        ///</example>
        public void suggest(JsString value) { }

        /// <summary>
        /// Gets/Sets the value of the autocomplete.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The value of the autocomplete.</returns>
        public JsString value(JsString value) { return null; }

        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var autoComplete = $("#autoComplete").data("kendoAutoComplete");
        ///$("#autoComplete").data("kendoAutoComplete").bind("change", function(e) {
        ///    // handle event
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    open: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> open { add { } remove { } }


        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        ///var onSelect = function(e) {
        ///    // access the selected item via e.item (jQuery object)
        ///};
        ///
        /// // attach select event handler during initialization
        ///var autocomplete = $("#autocomplete").kendoAutoComplete({
        ///    select: onSelect
        ///});
        ///
        /// // detach select event handler via unbind()
        ///autocomplete.data("kendoAutoComplete").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent { add { } remove { } }
        //TODO: event name is select

    }

    public class AutoCompleteConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn of the animation.
        /// </summary>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// The set of data that the AutoComplete will be bound to. Either a local JavaScript object, or an instance of the Kendo UI DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }
        /// <summary>
        /// The set of data that the AutoComplete will be bound to. Either a local JavaScript object, or an instance of the Kendo UI DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: null) Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { ID: 1, Name: "Item 1" }, { ID: 2, Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({
        ///    dataSource: items,
        ///    dataTextField: "Name"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        ///(default: 200) Specifies the delay in ms after which the AutoComplete will start filtering the dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the delay to 500 milliseconds
        ///$("#autoComplete").kendoAutoComplete({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the AutoComplete should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // disable the autocomplete when it is created (enabled by default)
        ///$("#autoComplete").kendoAutoComplete({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: "startswith") Defines the type of filtration. This value is handled by the remote data source.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // send a filter value of 'contains' to the server
        ///$("#autoComplete").kendoAutoComplete({
        ///    filter: 'contains'
        ///});
        ///</code>
        ///</example>
        public JsString filter { get; set; }

        /// <summary>
        /// (default: 200) Sets the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the height of the drop-down list that appears when the autocomplete is activated to 500px
        ///$("#autoComplete").kendoAutoComplete({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Controls whether the first item will be automatically highlighted.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autocomplete").kendoAutoComplete({
        ///    highlightFirst: false //no of the suggested items will be highlighted
        ///});
        ///</code>
        ///</example>
        public bool highlightFirst { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public JsString ignoreCase { get; set; }
        //TODO: seems like they have a mistake. if default: true should it be boolean?

        /// <summary>
        /// (default: 1) Specifies the minimum number of characters that should be typed before the AutoComplete queries the dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // wait until the user types 3 characters before querying the server
        ///$("#autoComplete").kendoAutoComplete({
        ///    minLength: 3
        ///});
        ///</code>
        ///</example>
        public JsNumber minLength { get; set; }

        /// <summary>
        /// (default: "")A string that appears in the textbox when it has no value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //autocomplete initialization
        ///&lt;script>
        ///    $("#autocomplete").kendoAutoComplete({
        ///        dataSource: dataSource,
        ///        placeholder: "Enter value..."
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: "")Sets the separator for completion. Empty by default, allowing for only one completion.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set completion separator to ,
        ///$("#autoComplete").kendoAutoComplete({
        ///    separator: ", "
        ///});
        ///</code>
        ///</example> 
        public JsString separator { get; set; }

        /// <summary>
        /// (default: false)Controls whether the AutoComplete should automatically auto-type the rest of text.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // turn on auto-typing (off by default)
        ///$("#autoComplete").kendoAutoComplete({
        ///    suggest: true
        ///});
        ///</code>
        ///</example>
        public bool suggest { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        /// //autocomplete initialization
        /// &lt;script>
        ///     $("#autocomplete").kendoAutoComplete({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         template: kendo.template($("#template").html())
        ///     });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

    }

    public class EmptyEventData
    {
    }

    public class SelectEventData
    {
        /// <summary>
        /// The selected item chosen by a user.
        /// </summary>
        public jQuery.jQuery item { get; set; }
    }

    public class Calendar
    {
        /// <summary>
        /// Sets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Navigates to view
        /// </summary>
        /// <param name="value">Desired date</param>
        /// <param name="view">Desired view</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to the desired date
        ///calendar.navigate(value, view);
        ///</code>
        ///</example>
        public void navigate(JsDate value, JsString view) { }

        /// <summary>
        /// Navigates to the lower view
        /// </summary>
        /// <param name="value">Desired date</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate down
        ///calendar.navigateDown(value);
        ///</code>
        ///</example>
        public void navigateDown(JsDate value) { }

        /// <summary>
        /// Navigates to the future
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to future
        ///calendar.navigateToFuture();
        ///</code>
        ///</example>
        public void navigateToFuture() { }

        /// <summary>
        /// Navigates to the past
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to past
        ///calendar.navigateToPast();
        ///</code>
        ///</example>
        public void navigateToPast() { }

        /// <summary>
        /// Navigates to the upper view
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate up
        ///calendar.navigateUp();
        ///</code>
        ///</example>
        public void navigateUp() { }

        /// <summary>
        /// Sets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void value(JsDate value) { }

        /// <summary>
        /// Sets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the value of the calendar.
        ///var value = calendar.value();
        /// // set the value of the calendar.
        ///calendar.value(new Date());
        ///</code>
        ///</example>
        public JsDate value() { return null; }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the Kendo UI calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // bind to the change event
        ///calendar.bind("change", function(e) {
        ///     // handle event
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when navigate
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    navigate: function(e) {
        ///         // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> navigateEvent { add { } remove { } }
        //TODO: event name is navigate
    }

    public class CalendarConfiguration
    {

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    dates: [new Date(2000, 10, 10, 10, 0, 0), new Date(2000, 10, 10, 30, 0)] //can manipulate month template depending on this array.
        ///});
        ///</code>
        ///</example>
        public JsArray dates { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    depth: "year"
        ///});
        ///</code>
        ///</example>
        public JsString depth { get; set; }

        /// <summary>
        /// Can be boolean or string. Specifies the content of the footer. If false, the footer will not be rendered.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // change the footer text from the default current date
        ///$("#calendar").kendoCalendar({
        ///    footer = "My Custom Footer"
        ///});
        ///</code>
        ///</example>
        public object footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    start: "year"
        ///});
        ///</code>
        ///</example>\
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected date to Jan 1st. 2012
        ///$("#calendar").kendoCalendar({
        ///    value: new Date(2012, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }
    }

    public class MonthConfiguration
    {
        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are in range.
        /// </summary>
        public JsString content { get; set; }

        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are not in the min/max range.
        /// </summary>
        public JsString empty { get; set; }
    }

    public class ComboBox
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index. If the index is not specified, the selected index will be used.
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the dataItem corresponding to the selectedIndex.
        /// var dataItem = combobox.dataItem();
        /// // get the dataItem corresponding to the passed index.
        /// var dataItem = combobox.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enables/disables the combobox widget
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Opens the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI ComboBox
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // re-render the items of the drop-down list.
        ///combobox.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Filters dataSource using the provided parameter and rebinds drop-down list.
        /// </summary>
        /// <param name="word">The filter value.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // Searches for item which has "In" in the name.
        /// combobox.search("In");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(jQuery.jQuery li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(object li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"\
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(JsAction li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"

        /// <summary>
        /// Forces a suggestion onto the text of the ComboBox.
        /// </summary>
        /// <param name="value">Characters to force a suggestion.</param>
        ///<example>
        ///usage
        ///<code>
        /// // note that this suggest is not the same as the configuration method
        /// // suggest which enables/disables auto suggesting for the ComboBox
        /// //
        /// // get a referenence to the Kendo UI ComboBox
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // force a suggestion to the item with the name "Inception"
        /// combobox.suggest("Inception");
        ///</code>
        ///</example>
        public void suggest(JsString value) { }

        /// <summary>
        /// Sets the text of the ComboBox.
        /// </summary>
        /// <param name="text">The text to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public void text(JsString text) { }

        /// <summary>
        /// Gets the text of the ComboBox.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public JsString text() { return null; }

        /// <summary>
        /// Toggles the drop-down list between opened and closed state.
        /// </summary>
        /// <param name="toggle">Defines the whether to open/close the drop-down list.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // toggles the open state of the drop-down list.
        /// combobox.toggle();
        ///</code>
        ///</example>
        public void toggle(bool toggle) { }

        /// <summary>
        /// Sets the value of the combobox. If the value is undefined, text of the data item will be used.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the combobox. If the value is undefined, text of the data item will be used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }


        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> openEvent { add { } remove { } }
        //TODO: event name is open

        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent { add { } remove { } }
        //TODO: event name is select

    }

    public class ComboBoxConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// Controls whether to bind the widget to the DataSource on initialization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    autoBind: false
        ///});
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// Use it to set the Id of the parent DropDownList.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist1").kendoDropDownList();
        ///$("#dropdownlist2").kendoDropDownList({
        ///    cascadeFrom: "dropdownlist1"
        ///});
        ///</code>
        ///</example>
        public JsString cascadeFrom { get; set; }

        /// <summary>
        /// A local JavaScript object or instance of DataSource or the data that the ComboBox will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }

        /// <summary>
        /// A local JavaScript object or instance of DataSource or the data that the ComboBox will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the value content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataValueField { get; set; }

        /// <summary>
        /// (default: 200) Specifies the delay in ms after which the ComboBox will start filtering dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the ComboBox should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: "none") Defines the type of filtration. If "none" the ComboBox will not filter the items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    filter: "startswith"
        ///});
        ///</code>
        ///</example>
        public JsString filter { get; set; }

        /// <summary>
        /// (default: 200) Define the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Controls whether the first item will be automatically highlighted.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    highLightFirst: true
        ///});
        ///</code>
        ///</example>   
        public bool highlightFirst { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public JsString ignoreCase { get; set; }

        /// <summary>
        /// (default: -1) Defines the initial selected item.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataSource: items,
        ///    index: 1 // 0 based from the start of the collection of objects. this selects "Item 2".
        ///});
        ///</code>
        ///</example>
        public JsNumber index { get; set; }

        /// <summary>
        /// (default: 1) Specifies the minimum characters that should be typed before the ComboBox activates
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    minLength: 3
        ///});
        ///</code>
        ///</example>
        public JsNumber minLength { get; set; }

        /// <summary>
        /// (default: "") A string that appears in the textbox when the combobox has no value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///    $("#combobox").kendoComboBox({
        ///        dataSource: dataSource,
        ///        placeholder: "Select..."
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: false) Controls whether the ComboBox should automatically auto-type the rest of text.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    suggest: false
        ///});
        ///</code>
        ///</example>
        public bool suggest { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        ///
        /// //combobox initialization
        /// &lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         dataValueField: "Id",
        ///         template: kendo.template($("#template").html())
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// (default: "") Define the text of the widget, when the autoBind is set to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     autoBind: false,
        ///     text: "Chai"
        ///});
        ///</code>
        ///</example>
        public JsString text { get; set; }

        /// <summary>
        /// (default: "") Define the value of the widget
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     dataSource: ["Item1", "Item2"],
        ///     value: "Item1"
        ///});
        ///</code>
        ///</example>
        public JsString value { get; set; }
    }

    public class AnimationConfiguration
    {
        /// <summary>
        /// Animation to be used for closing of the popup
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///    $("#combobox").kendoComboBox({
        ///        dataSource: dataSource,
        ///        animation: {
        ///           close: {
        ///               effects: "fadeOut",
        ///               duration: 300,
        ///               hide: true
        ///               show: false
        ///           }
        ///        }
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public object close { get; set; }

        /// <summary>
        /// Animation to be used for opening of the popup.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         animation: {
        ///            open: {
        ///                effects: "fadeIn",
        ///                duration: 300,
        ///                show: true
        ///            }
        ///         }
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public object open { get; set; }

    }

    public class DatePicker
    {
        /// <summary>
        /// Closes the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        ///autocomplete.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Enable/Disable the datePicker widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Sets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Opens the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Sets the value of the datePicker.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the datePicker.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the calendar is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the calendar is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<ViewOptions> openEvent { add { } remove { } }
        //TODO: event name is open
    }

    public class DatePickerConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade",
        ///    depth: "year" // the datePicker will only go to the year level
        ///});
        ///</code>
        ///</example>
        public StartDepthOptions depth { get; set; }

        /// <summary>
        /// Template to be used for rendering the footer of the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // DatePicker initialization
        /// &lt;script>
        ///     $("#datePicker").kendoDatePicker({
        ///         footer: "Today - #=kendo.toString(data, 'd') #"
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input.
        /// If not set the value of the format will be used. Note that value of the format option is always used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    format: "yyyy/MM/dd",
        ///    parseFormats: ["MMMM yyyy"] //format also will be added to parseFormats
        ///});
        ///</code>
        ///</example>
        public JsArray parseFormats { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade" // the datePicker will start with a decade display
        ///});
        ///</code>
        ///</example> 
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected value to January 1st, 2011
        ///$("#datePicker").kendoDatePicker({
        /// value: new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }


    }

    public enum StartDepthOptions
    {
        /// <summary>
        /// shows the days of the month
        /// </summary>
        month,
        /// <summary>
        /// shows the months of the year
        /// </summary>
        year,
        /// <summary>
        /// shows the years of the decade
        /// </summary>
        decade,
        /// <summary>
        /// shows the decades from the centery
        /// </summary>
        century,
    }

    public class DateTimePicker
    {

        /// <summary>
        /// Closes the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Closes the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date".</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").close("date");
        ///</code>
        ///</example>
        public void close(ViewOptions view) { }

        /// <summary>
        /// Enables or disables a DateTimePicker.
        /// </summary>
        /// <param name="enable">Enables (true or undefined) or disables (false) a DateTimePicker.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Sets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Opens the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("dateTimePicker").data("kendoDateTimePicker").open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Opens the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date"</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").open("date");
        ///</code>
        ///</example>
        public void open(ViewOptions view) { }

        /// <summary>
        /// Toggles the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").toggle("date");
        ///</code>
        ///</example>
        public void toggle() { }

        /// <summary>
        /// Toggles the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date".</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").toggle("date");
        ///</code>
        ///</example>
        public void toggle(ViewOptions view) { }

        /// <summary>
        /// Sets the value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the DateTimePicker.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }

        /// <summary>
        /// Triggered when the underlying value of a DateTimePicker is changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the calendar or the time drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the calendar or the time drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<ViewOptions> openEvent { add { } remove { } }
        //TODO: event name is open
    }

    public class DateTimePickerConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies a list of dates, which are shown in the time drop-down list. If not set, the DateTimePicker will auto-generate the available times.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    dates: [new Date(2000, 10, 10, 10, 0, 0), new Date(2000, 10, 10, 30, 0)] //the drop-down list will consist only two entries - "10:00 AM" and "10:30 AM"
        ///});
        ///</code>
        ///</example>
        public JsArray dates { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade",
        ///    depth: "year" // the datePicker will only go to the year level
        ///});
        ///</code>
        ///</example>
        public StartDepthOptions depth { get; set; }

        /// <summary>
        /// Template to be used for rendering the footer of the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // DatePicker initialization
        /// &lt;script>
        ///     $("#datePicker").kendoDatePicker({
        ///         footer: "Today - #=kendo.toString(data, 'd') #"
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: 30) Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    interval: 15
        ///});
        ///</code>
        ///</example>
        public JsNumber interval { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input.
        /// If not set the value of the format will be used. Note that value of the format option is always used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    format: "yyyy/MM/dd",
        ///    parseFormats: ["MMMM yyyy"] //format also will be added to parseFormats
        ///});
        ///</code>
        ///</example>
        public JsArray parseFormats { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade" // the datePicker will start with a decade display
        ///});
        ///</code>
        ///</example> 
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: h:mm tt) Specifies the format, which is used to format the values in the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    timeFormat: "HH:mm" //24 hours format
        ///});
        ///</code>
        ///</example>
        public JsString timeFormat { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected value to January 1st, 2011
        ///$("#datePicker").kendoDatePicker({
        /// value: new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }

    }

    public class OpenEventData
    {
        public ViewOptions view { get; set; }
    }

    public enum ViewOptions
    {
        date,
        time,
    }

    public class DropDownList
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index. If the index is not specified, the selected index will be used.
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the dataItem corresponding to the selectedIndex.
        /// var dataItem = combobox.dataItem();
        /// // get the dataItem corresponding to the passed index.
        /// var dataItem = combobox.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enables/disables the dropdownlist widget
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Opens the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI ComboBox
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // re-render the items of the drop-down list.
        ///combobox.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Selects item, which starts with the provided parameter.
        /// </summary>
        /// <param name="word">The search value.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // Searches for item which has "In" in the name.
        /// combobox.search("In");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(jQuery.jQuery li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(JsNumber li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"\
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(JsAction li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"

        /// <summary>
        /// Sets the text of the dropdownlist.
        /// </summary>
        /// <param name="text">The text to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public void text(JsString text) { }
        /// <summary>
        /// Gets the text of the dropdownlist.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public JsString text() { return null; }

        /// <summary>
        /// Toggles the drop-down list between opened and closed state.
        /// </summary>
        /// <param name="toggle">Defines the whether to open/close the drop-down list.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // toggles the open state of the drop-down list.
        /// combobox.toggle();
        ///</code>
        ///</example>
        public void toggle(bool toggle) { }

        /// <summary>
        /// Sets the value of the dropdownlist. The value will not be set if there is no item with such value. If value is undefined, text of the data item is used.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }
        /// <summary>
        /// Gets the value of the dropdownlist. The value will not be set if there is no item with such value. If value is undefined, text of the data item is used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }


        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> openEvent { add { } remove { } }
        //TODO: event name is open

        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent { add { } remove { } }
        //TODO: event name is select

    }

    public class DropDownListConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: true) Controls whether to bind the widget on initialization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    autoBind: false
        ///});
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// Use it to set the Id of the parent DropDownList.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist1").kendoDropDownList();
        ///$("#dropdownlist2").kendoDropDownList({
        ///    cascadeFrom: "dropdownlist1"
        ///});
        ///</code>
        ///</example>
        public JsString cascadeFrom { get; set; }

        /// <summary>
        /// Instance of DataSource or the data that the DropDownList will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }

        /// <summary>
        /// Instance of DataSource or the data that the DropDownList will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the value content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataValueField { get; set; }

        /// <summary>
        /// (default: 500) Specifies the delay in ms before the search text typed by the end user is cleared.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the DropDownList  should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: 200) Define the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public JsString ignoreCase { get; set; }
        //todo: if (default: true) why string and not boolean?

        /// <summary>
        /// (default: 0) Defines the initial selected item.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataSource: items,
        ///    index: 1 // 0 based from the start of the collection of objects. this selects "Item 2".
        ///});
        ///</code>
        ///</example>
        public JsNumber index { get; set; }

        /// <summary>
        /// Define the text of the default empty item. If the value is an object, then the widget will use it directly.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist").kendoDropDownList({
        ///    optionLabel: "Select An Option"
        ///});
        ///</code>
        ///</example>
        public object optionLabel { get; set; }

        /// <summary>
        /// Define the text of the default empty item. If the value is an object, then the widget will use it directly.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist").kendoDropDownList({
        ///    optionLabel: "Select An Option"
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "optionLabel")]
        public JsString optionLabelString { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        ///
        /// //combobox initialization
        /// &lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         dataValueField: "Id",
        ///         template: kendo.template($("#template").html())
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// (default: "") Define the text of the widget, when the autoBind is set to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     autoBind: false,
        ///     text: "Chai"
        ///});
        ///</code>
        ///</example>
        public JsString text { get; set; }

        /// <summary>
        /// (default: "") Define the value of the widget
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     dataSource: ["Item1", "Item2"],
        ///     value: "Item1"
        ///});
        ///</code>
        ///</example>
        public JsString value { get; set; }
    }

    public class Editor
    {
        /// <summary>
        /// Creates a W3C-compatible Range object.
        /// </summary>
        /// <param name="document">The document that the range is associated with. If ommited, the document of the editor editing area will be used.</param>
        /// <returns>Range. The created Range object.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///var range = editor.createRange();
        ///</code>
        ///</example>
        public HtmlTextRange createRange(HtmlDocument document) { return null; }

        /// <summary>
        /// Gets the HTML encoded value of the editor.
        /// </summary>
        /// <returns></returns>
        public JsString encodedValue() { return null; }

        /// <summary>
        /// Executes an editor command on the currently selected text.
        /// </summary>
        /// <param name="name">The name of the command to be executed.</param>
        /// <param name="params">The parameters for the executed command.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///editor.exec("bold");
        ///editor.exec("undo");
        ///editor.exec("foreColor", { value: "#ff0000" });
        ///</code>
        ///</example>
        public void exec(JsString name, JsString @params) { }
        //TODO: params optinal?

        /// <summary>
        /// Focuses the editable area.
        /// </summary>
        public void focus() { }

        /// <summary>
        /// Gets a Range object form the editable area.
        /// </summary>
        /// <returns>Range A W3C-compatible Range object that represents the currently selected text in the editor area.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///var range = editor.getRange();
        ///</code>
        ///</example>
        public object getRange() { return null; }
        //TODO: return type?

        /// <summary>
        /// Gets a W3C-compatible Selection object form the editable area.
        /// </summary>
        /// <returns></returns>
        public object getSelection() { return null; }
        //TODO: return type?

        /// <summary>
        /// Pastes HTML into the editable area.
        /// </summary>
        /// <param name="html">The HTML to be pasted.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///editor.paste("<p>new content</p>");
        ///</code>
        ///</example>
        public void paste(JsString html) { }

        /// <summary>
        /// Serializes the currently selected text to a XHTML string.
        /// </summary>
        /// <returns>String The selectied text as valid XHTML.</returns>
        public JsString selectedHtml() { return null; }

        /// <summary>
        /// Focuses the editable area and selects the range described by the range parameter.
        /// </summary>
        /// <param name="range">The Range object that describes the new selection.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor"),
        ///    range = editor.createRange();
        ///range.selectNodeContents(editor.body);
        ///editor.selectRange(range);
        ///</code>
        ///</example>
        public void selectRange(HtmlTextRange range) { }

        //TODO: update


    }

    public class EditorConfiguration
    {
        /// <summary>
        /// (default: true) Indicates whether the Editor should submit encoded HTML tags.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///    encoded: false
        ///});
        ///</code>
        ///</example>
        public bool encoded { get; set; }

        /// <summary>
        /// Allows custom stylesheets to be included within the editing area.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///     stylesheets: [
        ///         "common-styles.css",
        ///         "green-theme.css",
        ///     ]
        /// });
        ///</code>
        ///</example>
        public JsArray stylesheets { get; set; }

        /// <summary>
        /// A collection of tools that should render a button, combobox, etc, to interact with the Editor.
        /// Custom tools are defined as a collection of required properties, while the insertHtml tool requires a collection of text-value pairs
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///    tools: [
        ///        "bold",
        ///        "italic",
        ///        "underline",
        ///        "strikethrough",
        ///        "fontName",
        ///        "fontSize",
        ///        "foreColor",
        ///        "backColor",
        ///        "justifyLeft",
        ///        "justifyCenter",
        ///        "justifyRight",
        ///        "justifyFull",
        ///        "insertUnorderedList",
        ///        "insertOrderedList",
        ///        "indent",
        ///        "outdent",
        ///        "formatBlock",
        ///        "createLink",
        ///        "unlink",
        ///        "insertImage",
        ///        "insertHtml",
        ///        "viewHtml",
        ///        {
        ///            name: "customTool",
        ///            tooltip: "Custom Tool",
        ///            exec: function(e) {
        ///                var editor = $(this).data("kendoEditor");
        ///                // ...
        ///            }
        ///        }
        ///    ],
        ///    insertHtml: [
        ///        { text: "label 1", value: "<p>snippet 1</p>" },
        ///        { text: "label 2", value: "<p>snippet 2</p>" }
        ///    ]
        ///});
        ///</code>
        ///</example>
        public JsArray tools { get; set; }
    }

    public class Grid
    {
        /// <summary>
        /// Adds a new empty table row in edit mode. The addRow method triggers edit event.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.addRow();
        ///</code>
        ///</example>
        public void addRow() { }

        /// <summary>
        /// Cancels any pending changes during. Deleted rows are restored. Inserted rows are removed. Updated rows are restored to their original values.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.cancelChanges();
        ///</code>
        ///</example>
        public void cancelChanges() { }

        /// <summary>
        /// Switch the current edited row into display mode and revert changes made to the data
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.cancelRow();
        ///</code>
        ///</example>
        public void cancelRow() { }

        /// <summary>
        /// Returns the index of the cell in the grid item skipping group and hierarchy cells.
        /// </summary>
        /// <param name="cell">Target cell.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // get the index of the row
        /// // TODO: add specific function call here
        ///</code>
        ///</example>
        public JsNumber cellIndex(JsAction cell) { return null; }
        /// <summary>
        /// Returns the index of the cell in the grid item skipping group and hierarchy cells.
        /// </summary>
        /// <param name="cell">Target cell.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // get the index of the row
        /// // TODO: add specific function call here
        ///</code>
        ///</example>
        public JsNumber cellIndex(HtmlElement cell) { return null; }

        /// <summary>
        /// Clears currently selected items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // clear the selection of items in the grid
        ///grid.clearSelection();
        ///</code>
        ///</example>
        public void clearSelection() { }

        /// <summary>
        /// Closes current edited cell.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // close the cell being edited
        ///grid.closeCell();
        ///</code>
        ///</example>
        public void closeCell() { }

        /// <summary>
        /// Collapses specified group.
        /// </summary>
        /// <param name="group">Target group item to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first group item
        /// grid.collapseGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void collapseGroup(JsAction group) { }
        /// <summary>
        /// Collapses specified group.
        /// </summary>
        /// <param name="group">Target group item to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first group item
        /// grid.collapseGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void collapseGroup(HtmlElement group) { }

        /// <summary>
        /// Collapses specified master row.
        /// </summary>
        /// <param name="row ">Target master row to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first master row
        /// grid.collapseRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void collapseRow(JsAction row) { }
        /// <summary>
        /// Collapses specified master row.
        /// </summary>
        /// <param name="row ">Target master row to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first master row
        /// grid.collapseRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void collapseRow(HtmlElement row) { }

        /// <summary>
        /// Returns the data item to which a given table row (tr DOM element) is bound.
        /// </summary>
        /// <param name="tr  ">Target row.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // returns the data item for first row
        /// grid.dataItem(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public object dataItem(JsAction tr) { return null; }
        /// <summary>
        /// Returns the data item to which a given table row (tr DOM element) is bound.
        /// </summary>
        /// <param name="tr  ">Target row.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // returns the data item for first row
        /// grid.dataItem(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public object dataItem(HtmlElement tr) { return null; }

        /// <summary>
        /// Puts the specified table cell in edit mode. It requires a jQuery object representing the cell. The editCell method triggers edit event.
        /// </summary>
        /// <param name="cell">Cell to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // edit first table cell
        ///grid.editCell(grid.tbody.find(">tr>td:first"));
        ///</code>
        ///</example>
        public void editCell(JsAction cell) { }

        /// <summary>
        /// Switches the specified row from the grid into edit mode. The editRow method triggers edit event.
        /// </summary>
        /// <param name="row ">Row to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // edit first table row
        /// grid.editRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void editRow(JsAction row) { }
        /// <summary>
        /// Switches the specified row from the grid into edit mode. The editRow method triggers edit event.
        /// </summary>
        /// <param name="row ">Row to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // edit first table row
        /// grid.editRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void editRow(HtmlElement row) { }

        /// <summary>
        /// Expands specified group.
        /// </summary>
        /// <param name="group">Target group item to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first group item
        /// grid.expandGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void expandGroup(JsAction group) { }
        /// <summary>
        /// Expands specified group.
        /// </summary>
        /// <param name="group">Target group item to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first group item
        /// grid.expandGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void expandGroup(HtmlElement group) { }

        /// <summary>
        /// Expands specified master row.
        /// </summary>
        /// <param name="row ">Target master row to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first master row
        /// grid.expandRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void expandRow(JsAction row) { }
        /// <summary>
        /// Expands specified master row.
        /// </summary>
        /// <param name="row ">Target master row to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first master row
        /// grid.expandRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void expandRow(HtmlElement row) { }

        /// <summary>
        /// Redraws the grid using the current data of the DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // refreshes the grid
        /// grid.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Removes the specified row from the grid. The removeRow method triggers remove event. (Note: In inline or popup edit modes the changes will be automatically synced)
        /// </summary>
        /// <param name="row ">Row to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // remove first table row
        /// grid.removeRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void removeRow(JsAction row) { }
        /// <summary>
        /// Removes the specified row from the grid. The removeRow method triggers remove event. (Note: In inline or popup edit modes the changes will be automatically synced)
        /// </summary>
        /// <param name="row ">Row to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // remove first table row
        /// grid.removeRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void removeRow(HtmlElement row) { }

        /// <summary>
        /// Calls DataSource sync to submit any pending changes if state is valid. The saveChanges method triggers saveChanges event.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.saveChanges();
        ///</code>
        ///</example>
        public void saveChanges() { }

        /// <summary>
        /// Switch the current edited row into dislay mode and save changes made to the data (Note: the changes will be automatically synced)
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.saveRow();
        ///</code>
        ///</example>
        public void saveRow() { }

        /// <summary>
        /// Selects the specified Grid rows/cells. If called without arguments - returns the selected rows/cells.
        /// </summary>
        /// <param name="items ">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // selects first grid item
        /// grid.select(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void select(JsAction items) { }
        /// <summary>
        /// Selects the specified Grid rows/cells. If called without arguments - returns the selected rows/cells.
        /// </summary>
        /// <param name="items ">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // selects first grid item
        /// grid.select(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void select(HtmlElement items) { }


        /// <summary>
        /// Fires when the grid selection has changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the grid has received data from the data source.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     dataBound: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> dataBound { add { } remove { } }

        /// <summary>
        /// Fires when the grid detail row is collapsed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///  $("#grid").kendoGrid({
        ///     detailCollapse: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDataBoundEventData> dataBound { add { } remove { } }

        /// <summary>
        /// Fires when the grid detail row is expanded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     detailExpand: function(e) {
        ///         // handle event
        ///     }
        /// });
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDataBoundEventData> detailExpand { add { } remove { } }

        /// <summary>
        /// Fires when the grid detail is initialized.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     detailInit: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDetailInitEventData> detailInit { add { } remove { } }

        /// <summary>
        /// Fires when the grid enters edit mode.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     edit: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridEditEventData> edit { add { } remove { } }

        /// <summary>
        /// Fires before the grid item is removed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     remove: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridRemoveEventData> remove { add { } remove { } }

        /// <summary>
        /// Fires before the grid item is changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     save: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridSaveEventData> save { add { } remove { } }

        /// <summary>
        /// Fires before the grid calls DataSource sync.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     saveChanges: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> saveChanges { add { } remove { } }
    }

    public class GridConfiguration
    {

        /// <summary>
        /// Indicates whether the grid will call read on the DataSource initially.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: sharedDataSource,
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     autoBind: false // the grid will not be populated with data until read() is called on the sharedDataSource
        /// });
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// A collection of column objects or collection of strings that represents the name of the fields.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var sharedDataSource = new kendo.data.DataSource({
        ///     data: [{title: "Star Wars: A New Hope", year: 1977}, {title: "Star Wars: The Empire Strikes Back", year: 1980}],
        ///     pageSize: 1
        ///});
        ///$("#grid").kendoGrid({
        ///    dataSource: sharedDataSource,
        ///    columns: [ { title: "Action", command: "destroy" }, // creates a column with delete buttons
        ///               { title: "Title", field: "title", width: 200, template: "<div id='title'>${ title }</div>" },
        ///               { title: "Year", field: "year", filterable: false, sortable: true, format: "{0:dd/MMMM/yyyy}" } ];
        ///});
        ///</code>
        ///</example>
        public GridColumnsConfiguration columns { get; set; }
        /// <summary>
        /// A collection of column objects or collection of strings that represents the name of the fields.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var sharedDataSource = new kendo.data.DataSource({
        ///     data: [{title: "Star Wars: A New Hope", year: 1977}, {title: "Star Wars: The Empire Strikes Back", year: 1980}],
        ///     pageSize: 1
        ///});
        ///$("#grid").kendoGrid({
        ///    dataSource: sharedDataSource,
        ///    columns: [ { title: "Action", command: "destroy" }, // creates a column with delete buttons
        ///               { title: "Title", field: "title", width: 200, template: "<div id='title'>${ title }</div>" },
        ///               { title: "Year", field: "year", filterable: false, sortable: true, format: "{0:dd/MMMM/yyyy}" } ];
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "columns")]
        public JsArray columnsArray { get; set; }
        //TODO: not sure if needed

        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }
        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// Template to be used for rendering the detail rows in the grid. See the Detail Template example.
        /// </summary>
        public JsAction detailTemplate { get; set; }

        /// <summary>
        /// Indicates whether editing is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ]
        ///     toolbar: [
        ///         "create",
        ///         { name: "save", text: "Save This Record" },
        ///         { name: "cancel", template: "&lt;img src="icons/cancel.png' rel='cancel' />" }
        ///     ],
        ///     editable: {
        ///         update: true, // puts the row in edit mode when it is clicked
        ///         destroy: false, // does not remove the row when it is deleted, but marks it for deletion
        ///         confirmation: "Are you sure you want to remove this item?"
        ///     }
        /// });
        ///</code>
        ///</example>   
        public GridEditableConfiguration editable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether grouping is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     groupable: true
        /// });
        ///</code>
        ///</example>
        public bool groupable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     navigatable: true
        /// });
        ///</code>
        ///</example>
        public bool navigatable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "pageable")]
        public bool pageableBoolean { get; set; }

        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "pageable")]
        public object pageableObject { get; set; }

        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        public GridPageableConfiguration pageable { get; set; }

        /// <summary>
        /// Template to be used for rendering the rows in the grid.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        /// &lt;script id="rowTemplate" type="text/x-kendo-tmpl">
        ///     &lt;tr>
        ///         &lt;td>
        ///             &lt;img src="${ BoxArt.SmallUrl }" alt="${ Name }" />
        ///         &lt;/td>
        ///         &lt;td>
        ///             ${ Name }
        ///         &lt;/td>
        ///         &lt;td>
        ///             ${ AverageRating }
        ///         &lt;/td>
        ///     &lt;/tr>
        /// &lt;/script>
        ///
        /// //grid intialization
        /// &lt;script>PO details informaiton
        ///     $("#grid").kendoGrid({
        ///         dataSource: dataSource,
        ///         rowTemplate: kendo.template($("#rowTemplate").html()),
        ///         height: 200
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsAction rowTemplate { get; set; }

        /// <summary>
        /// (default: true) Enable/disable grid scrolling. Possible values:
        /// true
        ///Enables grid vertical scrolling
        ///false
        ///Disables grid vertical scrolling
        ///{ virtual: false }
        ///Enables grid vertical scrolling without data virtualization. Same as first option.
        ///{ virtual: true }
        ///Enables grid vertical scrolling with data virtualization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     scrollable: {
        ///         virtual: true //false
        ///     }
        /// });
        ///</code>
        ///</example>
        public bool scrollable { get; set; }
        /// <summary>
        /// (default: true) Enable/disable grid scrolling. Possible values:
        /// true
        ///Enables grid vertical scrolling
        ///false
        ///Disables grid vertical scrolling
        ///{ virtual: false }
        ///Enables grid vertical scrolling without data virtualization. Same as first option.
        ///{ virtual: true }
        ///Enables grid vertical scrolling with data virtualization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     scrollable: {
        ///         virtual: true //false
        ///     }
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "scrollable")]
        public object scrollableObject { get; set; }

        /// <summary>
        /// (default: undefined) Indicates whether selection is enabled/disabled. 
        /// </summary>
        public GridSelectableOptions selectable { get; set; }

        /// <summary>
        /// Defines whether grid columns are sortable.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     sortable: true
        /// });
        /// //
        /// // or
        /// //
        /// $("#grid").kendoGrid({
        ///     sortable: {
        ///         mode: "multiple", // enables multi-column sorting
        ///         allowUnsort: true
        /// });
        ///</code>
        ///</example>
        public GridSortableConfiguration sortable { get; set; }

        /// <summary>
        /// This is a list of commands for which the corresponding buttons will be rendered. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        public GridSortableToolbarConfiguration toolbar { get; set; }

        /// <summary>
        /// This is a list of commands for which the corresponding buttons will be rendered. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        [JsProperty(Name = "toolbar")]
        public GridSortableToolbarCommandsOptions toolbarBuildInCommands { get; set; }
        //TODO: check if neeeded 



    }

    public enum GridSelectableOptions
    {
        /// <summary>
        /// Single row selection.
        /// </summary>
        row,
        /// <summary>
        /// Single cell selection.
        /// </summary>
        cell,
        /// <summary>
        /// Multiple row selection.
        /// </summary>
        multipleRow,
        /// <summary>
        /// Multiple cell selection.
        /// </summary>
        multipleCell

    }

    public class GridColumnsConfiguration
    {
        /// <summary>
        /// Definition of command column. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        public ColumnsCommandOptions command { get; set; }
        /// <summary>
        /// Definition of command column. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        [JsProperty(Name = "command")]
        public JsString commandString { get; set; }
        //TODO: not sure if needed

        /// <summary>
        /// Provides a way to specify custom editor for this column.
        /// </summary>
        public ColumnsEditorConfiguration editor { get; set; }
        /// <summary>
        /// Provides a way to specify custom editor for this column.
        /// </summary>
        [JsProperty(Name = "editor")]
        public JsAction editorFunction { get; set; }
        //TODO: not sure if needed

        /// <summary>
        /// (default: true) Specified whether the column content is escaped. Disable encoding if the data contains HTML markup.
        /// </summary>
        public bool encoded { get; set; }

        /// <summary>
        /// The field from the datasource that will be displayed in the column.
        /// </summary>
        public JsString field { get; set; }

        /// <summary>
        /// (default: true) Specifies whether given column is filterable.
        /// </summary>
        public bool filterable { get; set; }

        /// <summary>
        /// The format that will be applied on the column cells.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             format: "{0:dd/MMMM/yyyy}"
        ///        }
        ///     ]
        ///  });
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: true) Specifies whether given column is sortable.
        /// </summary>
        public bool sortable { get; set; }

        /// <summary>
        /// The template for column's cells.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ]
        ///  });
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// The text that will be displayed in the column header.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// The width of the column.
        /// </summary>
        public JsString width { get; set; }

    }

    public enum ColumnsCommandOptions
    {
        create,
        cancel,
        save,
        destroy,

    }

    public class ColumnsEditorConfiguration
    {
        /// <summary>
        /// The container in which the editor must be added.
        /// </summary>
        public object container { get; set; }

        /// <summary>
        /// Additional options.
        /// </summary>
        public ColumnsEditorOptionsConfiguration options { get; set; }
    }
    public class ColumnsEditorOptionsConfiguration
    {
        /// <summary>
        /// The field for the editor.
        /// </summary>
        public JsString field { get; set; }

        /// <summary>
        /// The model for the editor.
        /// </summary>
        public object model { get; set; }
    }

    public class GridEditableConfiguration
    {
        /// <summary>
        /// Defines the text that will be used in confirmation box when delete an item.
        /// </summary>
        public bool confirmation { get; set; }
        /// <summary>
        /// Defines the text that will be used in confirmation box when delete an item.
        /// </summary>
        [JsProperty(Name = "confirmation")]
        public JsString confirmationString { get; set; }

        /// <summary>
        /// Indicates whether item should be deleted when click on delete button.
        /// </summary>
        public bool destroy { get; set; }

        /// <summary>
        /// Indicates which of the available edit modes(incell(default)/inline/popup) will be used
        /// </summary>
        public JsString mode { get; set; }

        /// <summary>
        /// Template which will be use during popup editing
        /// </summary>
        public JsString template { get; set; }

        /// <summary>
        /// Indicates whether item should be switched to edit mode on click.
        /// </summary>
        public bool update { get; set; }
    }

    public class GridPageableConfiguration
    {
        /// <summary>
        /// Defines the number of records which will be displyed.
        /// </summary>
        public JsNumber pageSize { get; set; }

        /// <summary>
        /// (default: true) Defines if buttons for navigating to the first, last, previous and next pages will be shown.
        /// </summary>
        public bool previousNext { get; set; }

        /// <summary>
        /// (default: true) Defines if numeric portion of the pager will be shown.
        /// </summary>
        public bool numeric { get; set; }

        /// <summary>
        /// (default: 10) Defines the number of buttons displayed in the numeric pager.
        /// </summary>
        public JsNumber buttonCount { get; set; }

        /// <summary>
        /// (default: false) Defines if an input element which allows the user to navigate to given page will be displayed.
        /// </summary>
        public bool input { get; set; }

        /// <summary>
        /// (default: false)Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        public bool pageSizes { get; set; }
        /// <summary>
        /// (default: [5,10,20])Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        [JsProperty(Name = "pageSizes")]
        public JsArray pageSizesArray { get; set; }

        /// <summary>
        /// (default: false) Defines if a refresh button will be displayed.
        /// </summary>
        public bool refresh { get; set; }

        /// <summary>
        /// (default: true) Defines if a label showing current paging information will be displayed.
        /// </summary>
        public bool info { get; set; }

        /// <summary>
        /// Defines texts shown within the pager.
        /// </summary>
        public GridPageableMessagesConfiguration messages { get; set; }

    }

    public class GridPageableMessagesConfiguration
    {
        /// <summary>
        /// (default: "{0} - {1} of {2} items"), Defines the info text.
        /// </summary>
        public JsString display { get; set; }

        /// <summary>
        /// (default: "No items to display"), Defines the info text shown when there are no records to be displayed.
        /// </summary>
        public JsString empty { get; set; }

        /// <summary>
        /// (default: "Page"), Defines the first part of the text of the input option.
        /// </summary>
        public JsString page { get; set; }

        /// <summary>
        /// (default: "of {0}"), Defines the last part of the text of the input option.
        /// </summary>
        public JsString of { get; set; }

        /// <summary>
        /// (default: "items per page"), Defines the text displayed after the select element of the pageSizes mode.
        /// </summary>
        public JsString itemsPerPage { get; set; }

        /// <summary>
        /// (default: "Go to the first page"), Defines the text of the first page button tooltip.
        /// </summary>
        public JsString first { get; set; }

        /// <summary>
        /// (default: "Go to the previous page"), Defines the text of the previous page button tooltip.
        /// </summary>
        public JsString previous { get; set; }

        /// <summary>
        /// (default: "Go to the next page"), Defines the text of the next page button tooltip.
        /// </summary>
        public JsString next { get; set; }

        /// <summary>
        /// (default: "Go to the last page"), Defines the text of the last page button tooltip.
        /// </summary>
        public JsString last { get; set; }

        /// <summary>
        /// (default: "Refresh"), Defines the text of the refresh button tooltip.
        /// </summary>
        public JsString refresh { get; set; }
    }

    public class GridSortableConfiguration
    {
        /// <summary>
        /// (default: false) Defines whether column can have unsorted state.
        /// </summary>
        public bool allowUnsort { get; set; }

        public GridSortableModeOptions mode { get; set; }

    }

    public enum GridSortableModeOptions
    {
        /// <summary>
        /// Defines that only once column can be sorted at a time.
        /// </summary>
        single,
        /// <summary>
        /// Defines that multiple columns can be sorted at a time.
        /// </summary>
        multiple,
    }
    public enum GridSortableToolbarCommandsOptions
    {
        create,
        cancel,
        save,
        destroy,
    }
    public class GridSortableToolbarConfiguration
    {
        /// <summary>
        /// The name of the command. One of the predefined or a custom.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// The template for the command button.
        /// </summary>
        public JsString template { get; set; }

        /// <summary>
        /// The text of the command that will be set on the button.
        /// </summary>
        public JsString text { get; set; }

    }

    public class GridDataBoundEventData
    {
        /// <summary>
        /// The jQuery element representing master row.
        /// </summary>
        public object masterRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail row.
        /// </summary>
        public object detailRow { get; set; }
    }

    public class GridDetailInitEventData
    {
        /// <summary>
        /// The jQuery element representing master row.
        /// </summary>
        public object masterRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail row.
        /// </summary>
        public object detailRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail cell.
        /// </summary>
        public object detailCell { get; set; }

        /// <summary>
        /// The data for the master row.
        /// </summary>
        public object data { get; set; }

    }

    public class GridEditEventData
    {
        /// <summary>
        /// The jQuery element to be edited.
        /// </summary>
        public object container { get; set; }

        /// <summary>
        /// The model to be edited.
        /// </summary>
        public object model { get; set; }
    }

    public class GridRemoveEventData
    {
        /// <summary>
        /// The row element to be deleted.
        /// </summary>
        public object row { get; set; }

        /// <summary>
        /// The model which to be deleted.
        /// </summary>
        public object model { get; set; }
    }

    public class GridSaveEventData
    {
        /// <summary>
        /// The values entered by the user.
        /// </summary>
        public object values { get; set; }

        /// <summary>
        /// The jQuery element which is in edit mode.
        /// </summary>
        public object container { get; set; }

        /// <summary>
        /// The edited model.
        /// </summary>
        public object model { get; set; }
    }
}

