using Common.Repository;
using DataRoom.Contract.Enums;

namespace DataRoom.Contract.Entities
{
    public class Node : EntityVersionable
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public NodeType NodeType { get; set; }
    }
}
