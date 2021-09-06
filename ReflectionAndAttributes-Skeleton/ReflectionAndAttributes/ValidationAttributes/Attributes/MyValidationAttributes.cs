using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    public abstract class MyValidationAttributes : Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
