//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// The CartesianChart class creates a chart with horizontal and vertical axes.
    /// </summary>
    public partial class CartesianChart
    {
        /// <summary>
        /// Adds axis instance to the appropriate array based on position
        /// </summary>
        public void _addToAxesCollection(object position, Axis axis){}
        [JsMethod(JsonInitializers=true)]
        public CartesianChart(){}
        /// <summary>
        /// Returns all the keys contained in a  `dataProvider`.
        /// </summary>
        public object _getAllKeys(Y_.Array dp){return null;}
        /// <summary>
        /// Returns the appropriate message based on the key press.
        /// </summary>
        public object _getAriaMessage(Y_.DataType_.Number key){return null;}
        /// <summary>
        /// Destructor implementation for the CartesianChart class. Calls destroy on all axes, series and the Graph instance.
        /// Removes the tooltip and overlay HTML elements.
        /// </summary>
        protected void destructor(){}
        /// <summary>
        /// Returns an object literal containing a categoryItem and a valueItem for a given series index. Below is the structure of each:
        /// </summary>
        public object getSeriesItems(CartesianSeries series, Y_.DataType_.Number index){return null;}
        /// <summary>
        /// Axes to appear in the chart. This can be a key indexed hash of axis instances or object literals
        /// used to construct the appropriate axes.
        /// </summary>
        public object axes{get;set;}
        /// <summary>
        /// Reference to the category axis used by the chart.
        /// </summary>
        public Axis categoryAxis{get;set;}
        /// <summary>
        /// Reference to the horizontalGridlines for the chart.
        /// </summary>
        public Gridlines horizontalGridlines{get;set;}
        /// <summary>
        /// Collection of series to appear on the chart. This can be an array of Series instances or object literals
        /// used to construct the appropriate series.
        /// </summary>
        public Y_.Array seriesCollection{get;set;}
        /// <summary>
        /// Style properties for the chart. Contains a key indexed hash of the following:
        /// <dl>
        /// <dt>series</dt><dd>A key indexed hash containing references to the `styles` attribute for each series in the chart.
        /// Specific style attributes vary depending on the series:
        /// <ul>
        /// <li><a href="AreaSeries.html#attr_styles">AreaSeries</a></li>
        /// <li><a href="BarSeries.html#attr_styles">BarSeries</a></li>
        /// <li><a href="ColumnSeries.html#attr_styles">ColumnSeries</a></li>
        /// <li><a href="ComboSeries.html#attr_styles">ComboSeries</a></li>
        /// <li><a href="LineSeries.html#attr_styles">LineSeries</a></li>
        /// <li><a href="MarkerSeries.html#attr_styles">MarkerSeries</a></li>
        /// <li><a href="SplineSeries.html#attr_styles">SplineSeries</a></li>
        /// </ul>
        /// </dd>
        /// <dt>axes</dt><dd>A key indexed hash containing references to the `styles` attribute for each axes in the chart. Specific
        /// style attributes can be found in the <a href="Axis.html#attr_styles">Axis</a> class.</dd>
        /// <dt>graph</dt><dd>A reference to the `styles` attribute in the chart. Specific style attributes can be found in the
        /// <a href="Graph.html#attr_styles">Graph</a> class.</dd>
        /// </dl>
        /// </summary>
        public object styles{get;set;}
        /// <summary>
        /// Reference to the verticalGridlines for the chart.
        /// </summary>
        public Gridlines verticalGridlines{get;set;}
    }
}