using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes()
                    .Cast<MyValidationAttributes>()
                    .ToArray();

                object value = property.GetValue(obj);

                foreach (var attribute in attributes)
                {
                    bool isValid = attribute.IsValid(value);

                    if (!isValid)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
