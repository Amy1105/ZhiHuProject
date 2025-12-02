using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    /// <summary>
    /// 添加人、最后一次更新人
    /// </summary>
    public abstract class AuditWithUserEntity:BaseAuditEntity
    {
        public int? CreatedBy { get; set; }

        public int? LastModifiedBy { get;set; }
    }
}
