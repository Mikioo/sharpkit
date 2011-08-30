using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    public interface UndoManager
    {
        // UndoManager
        int length {get;}
        [JsProperty(NativeIndexer = true)]
        object this[int index] { get; }
        int position {get;}
        int add(object data, JsString title);
        void remove(int index);
        void clearUndo();
        void clearRedo();
    }

}