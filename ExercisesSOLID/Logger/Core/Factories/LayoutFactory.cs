using System;
using System.Collections.Generic;
using System.Text;
using Logger.Layouts;

namespace Logger.Core.Factories
{
    class LayoutFactory : ILayoutFactory
    {
        public ILayout createLayout(string type)
        {
            ILayout layout;

            switch (type)
            {
                case nameof(SimpleLayout):
                    layout = new SimpleLayout();
                    break;
                
                case nameof(XmlLayout):
                    layout = new XmlLayout();
                    break;
                default:
                    throw new ArgumentException($"{type} is invalid Layout type.");
            }
            return layout;
        }
    }
}
