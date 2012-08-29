//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.column
namespace Ext.grid.column
{
    #region Date
    /// <inheritdocs />
    /// <summary>
    /// <p>A Column definition class which renders a passed date according to the default locale, or a configured
    /// <see cref="Ext.grid.column.DateConfig.format">format</see>.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// storeId:'sampleStore',
    /// fields:[
    /// { name: 'symbol', type: 'string' },
    /// { name: 'date',   type: 'date' },
    /// { name: 'change', type: 'number' },
    /// { name: 'volume', type: 'number' },
    /// { name: 'topday', type: 'date' }
    /// ],
    /// data:[
    /// { symbol: "msft",   date: '2011/04/22', change: 2.43, volume: 61606325, topday: '04/01/2010' },
    /// { symbol: "goog",   date: '2011/04/22', change: 0.81, volume: 3053782,  topday: '04/11/2010' },
    /// { symbol: "apple",  date: '2011/04/22', change: 1.35, volume: 24484858, topday: '04/28/2010' },
    /// { symbol: "sencha", date: '2011/04/22', change: 8.85, volume: 5556351,  topday: '04/22/2010' }
    /// ]
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// title: 'Date Column Demo',
    /// store: <see cref="Ext.data.StoreManager.lookup">Ext.data.StoreManager.lookup</see>('sampleStore'),
    /// columns: [
    /// { text: 'Symbol',   dataIndex: 'symbol', flex: 1 },
    /// { text: 'Date',     dataIndex: 'date',   xtype: 'datecolumn',   format:'Y-m-d' },
    /// { text: 'Change',   dataIndex: 'change', xtype: 'numbercolumn', format:'0.00' },
    /// { text: 'Volume',   dataIndex: 'volume', xtype: 'numbercolumn', format:'0,000' },
    /// { text: 'Top Day',  dataIndex: 'topday', xtype: 'datecolumn',   format:'l' }
    /// ],
    /// height: 200,
    /// width: 450,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Date : Ext.grid.column.Column
    {
        /// <summary>
        /// A formatting string as used by Ext.Date.format to format a Date for this Column.
        /// Defaults to the default date from <see cref="Ext.Date.defaultFormat">Ext.Date.defaultFormat</see> which itself my be overridden
        /// in a locale file.
        /// </summary>
        public JsString format;
        public Date(Ext.grid.column.DateConfig config){}
        public Date(){}
        public Date(params object[] args){}
    }
    #endregion
    #region DateConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DateConfig : Ext.grid.column.ColumnConfig
    {
        /// <summary>
        /// A formatting string as used by Ext.Date.format to format a Date for this Column.
        /// Defaults to the default date from <see cref="Ext.Date.defaultFormat">Ext.Date.defaultFormat</see> which itself my be overridden
        /// in a locale file.
        /// </summary>
        public JsString format;
        public DateConfig(params object[] args){}
    }
    #endregion
    #region DateEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DateEvents : Ext.grid.column.ColumnEvents
    {
        public DateEvents(params object[] args){}
    }
    #endregion
}
#endregion
