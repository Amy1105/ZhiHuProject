using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    /// <summary>
    /// 添加时间、最后一次修改时间
    /// </summary>
    public abstract class BaseAuditEntity:BaseEntity
    {
        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? LastModifiedAt { get; set; }
    }
}
