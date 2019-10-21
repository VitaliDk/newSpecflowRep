using NLog;

namespace ComponentLibrary.BaseClasses
{
    public class BaseAction
    {
        protected static readonly Logger _Logger = LogManager.GetCurrentClassLogger();
    }
}