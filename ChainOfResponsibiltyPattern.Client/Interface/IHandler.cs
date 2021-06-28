namespace ChainOfResponsibiltyPattern.Client.Interface
{
    public interface IHandler
    {
        public object HandleRequest(object value, string name);
        public IHandler SetNextHandler(IHandler handler);
    }
}
