if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}
if (typeof($CreateDelegate)=='undefined'){
    if(typeof($iKey)=='undefined') var $iKey = 0;
    if(typeof($pKey)=='undefined') var $pKey = String.fromCharCode(1);
    var $CreateDelegate = function(target, func){
        if (target == null || func == null) 
            return func;
        if(func.target==target && func.func==func)
            return func;
        if (target.$delegateCache == null)
            target.$delegateCache = {};
        if (func.$key == null)
            func.$key = $pKey + String(++$iKey);
        var delegate;
        if(target.$delegateCache!=null)
            delegate = target.$delegateCache[func.$key];
        if (delegate == null){
            delegate = function(){
                return func.apply(target, arguments);
            };
            delegate.func = func;
            delegate.target = target;
            delegate.isDelegate = true;
            if(target.$delegateCache!=null)
                target.$delegateCache[func.$key] = delegate;
        }
        return delegate;
    }
}
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Events) == "undefined")
    CoreTests.Events = {};
CoreTests.Events.CustomEventsTest = function ()
{
};
CoreTests.Events.CustomEventsTest.prototype.foo = function ()
{
    var x = new CoreTests.Events.CustomEvents();
    x.MyEvent.add($CreateDelegate(this, this.x_MyEvent));
    x.MyEvent.remove($CreateDelegate(this, this.x_MyEvent));
};
CoreTests.Events.CustomEventsTest.prototype.x_MyEvent = function ()
{
    throw $CreateException(new System.NotImplementedException.ctor(), new Error());
};
