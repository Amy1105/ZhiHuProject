using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Domain
{
    public abstract class BaseEntity<TId> : IDBEntity<TId>
    {
        //这么写是什么意思 to do...
        public TId Id { get; set; } = default!;
    }
}
