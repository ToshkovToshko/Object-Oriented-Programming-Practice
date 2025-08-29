using Logger.Layouts;

namespace Logger.Core.Factories
{
    interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
