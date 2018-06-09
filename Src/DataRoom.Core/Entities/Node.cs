using Common.Repository;
using DataRoom.Core.Enums;

namespace DataRoom.Core.Entities
{
    public class Node : EntityVersionable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public NodeType NodeType { get; set; }
    }
}
