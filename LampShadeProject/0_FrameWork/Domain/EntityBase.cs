using System;
using System.Collections.Generic;
using System.Text;

namespace _0_FrameWork.Domain
{
    public class EntityBase
    {
        public long operationId { get; private set; }
        public DateTime CreationDate { get; private set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
