using System;
using System.Collections.Generic;
using System.Text;

namespace JsonApiGenerator
{
    public class Schema
    {
        public IReadOnlyList<Resource> Resources { get; }

        public IReadOnlyList<Relation> Relations { get; }

        public Schema(IReadOnlyList<Resource> resources, IReadOnlyList<Relation> relations)
        {
            this.Resources = resources ?? throw new ArgumentNullException(nameof(resources));
            this.Relations = relations ?? throw new ArgumentNullException(nameof(relations));
        }
    }
}
