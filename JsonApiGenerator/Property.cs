using System;

namespace JsonApiGenerator
{
    public class Property
    {
        public string Name { get; }

        public PropertyType PropertyType { get; }

        public bool Optional { get; }

        public bool Unique { get; }

        public Property(string name, PropertyType propertyType, bool optional, bool unique)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            PropertyType = propertyType;
            Optional = optional;
            Unique = unique;
        }
    }
}
