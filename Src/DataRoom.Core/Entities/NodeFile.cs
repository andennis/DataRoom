using System;
using System.Collections.Generic;
using System.Text;

namespace DataRoom.Core.Entities
{
    public class NodeFile : Node
    {
        public string MimeType { get; set; }
        public long FileStorageId { get; set; }
        public long FileSize { get; set; }
    }
}
