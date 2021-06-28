using ChainOfResponsibiltyPattern.Client.Interface;

namespace ChainOfResponsibiltyPattern.Client.Chain
{
    public class AbstractionHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual object HandleRequest(object value, string name)
        {
            if(_nextHandler == null)
            {
                return null;
            }
            return _nextHandler.HandleRequest(value, name);
        }

        public IHandler SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }
}
