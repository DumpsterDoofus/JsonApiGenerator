using System;
using System.Collections.Generic;

namespace JsonApiGenerator
{
    public class Resource
    {
        public string Name { get; }

        public IReadOnlyList<Property> Properties { get; }

        public Resource(string name, IReadOnlyList<Property> properties)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Properties = properties ?? throw new ArgumentNullException(nameof(properties));
        }
    }
}
