using System;
using System.Collections.Generic;
using System.Text;

namespace JsonApiGenerator
{
    public class Relation
    {
        public string Resource1Name { get; }

        public string Resource2Name { get; }

        public RelationType RelationType { get; }

        public DeleteBehavior DeleteBehavior { get; }

        public bool Optional { get; }

        public Relation(
          string resource1Name,
          string resource2Name,
          RelationType relationType,
          DeleteBehavior deleteBehavior,
          bool optional)
        {
            this.Resource1Name = resource1Name ?? throw new ArgumentNullException(nameof(resource1Name));
            this.Resource2Name = resource2Name ?? throw new ArgumentNullException(nameof(resource2Name));
            this.RelationType = relationType;
            this.DeleteBehavior = deleteBehavior;
            this.Optional = optional;
        }
    }
}
