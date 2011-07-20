//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region MixedCollection
    /// <summary>
    /// Represents a collection of a set of key and value pairs. Each key in the MixedCollection
    /// must be unique, the same key cannot exist twice. This collection is ordered, items in the
    /// collection can be accessed by index  or via the key. Newly added items are added to
    /// the end of the collection. This class is similar to Ext.util.HashMap however it
    /// is heavier and provides more functionality. Sample usage:
    /// var coll = new Ext.util.MixedCollection();
    /// coll.add(&#39;key1&#39;, &#39;val1&#39;);
    /// coll.add(&#39;key2&#39;, &#39;val2&#39;);
    /// coll.add(&#39;key3&#39;, &#39;val3&#39;);
    /// console.log(coll.get(&#39;key1&#39;)); // prints &#39;val1&#39;
    /// console.log(coll.indexOfKey(&#39;key3&#39;)); // prints 2
    /// The MixedCollection also has support for sorting and filtering of the values in the collection.
    /// var coll = new Ext.util.MixedCollection();
    /// coll.add(&#39;key1&#39;, 100);
    /// coll.add(&#39;key2&#39;, -100);
    /// coll.add(&#39;key3&#39;, 17);
    /// coll.add(&#39;key4&#39;, 0);
    /// var biggerThanZero = coll.filterBy(function(value){
    /// return value &gt; 0;
    /// });
    /// console.log(biggerThanZero.getCount()); // prints 2
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class MixedCollection : AbstractMixedCollection, Sortable, Observable
    {
        /// <summary>
        /// Creates new MixedCollection. ...
        /// </summary>
        public object constructor(bool allowFunctions, JsAction keyFn){return null;}
        /// <summary>
        /// Performs initialization of this mixin. ...
        /// </summary>
        public object initSortable(){return null;}
        /// <summary>
        /// Reorders each of the items based on a mapping from old index to new index. ...
        /// </summary>
        public object reorder(object mapping){return null;}
        /// <summary>
        /// Sorts the data in the Store by one or more of its properties. ...
        /// </summary>
        public object sort(object sorters, JsString direction, object where, object doSort){return null;}
        /// <summary>
        /// Sorts the collection by a single sorter function ...
        /// </summary>
        public object sortBy(JsAction sorterFn){return null;}
        /// <summary>
        /// Sorts this collection by keys. ...
        /// </summary>
        public object sortByKey(JsString direction=null, JsAction fn=null){return null;}
        public JsString sortRoot{get;set;}
        public JsString defaultSortDirection{get;set;}
        /// <summary>
        /// Flag denoting that this object is sortable. ...
        /// </summary>
        public bool isSortable{get;set;}
        public Ext.util.MixedCollection sorters{get;set;}
    }
    #endregion
    #region MixedCollectionConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class MixedCollectionConfig : AbstractMixedCollectionConfig
    {
    }
    #endregion
    #region MixedCollectionEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class MixedCollectionEvents : AbstractMixedCollectionEvents
    {
    }
    #endregion
}
#endregion
