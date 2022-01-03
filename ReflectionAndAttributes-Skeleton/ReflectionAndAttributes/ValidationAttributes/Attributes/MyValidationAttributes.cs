using System;

namespace ValidationAttributes.Attributes
{
    public abstract class MyValidationAttributes : Attribute
    {
        public abstract bool IsValid(object obj);
    }
}
