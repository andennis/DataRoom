using System;
using System.Collections.Generic;
using System.Text;
using Common.Repository;

namespace DataRoom.Core.Entities
{
    public class NodeProperty : EntityVersionable
    {
        public long Id { get; set; }
        public long NodeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
