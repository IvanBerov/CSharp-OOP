using System;
using System.Collections.Generic;
using System.Text;
using Logger.Layouts;

namespace Logger.Core.Factories
{
    public interface ILayoutFactory
    {
        ILayout createLayout(string type);
    }
}
