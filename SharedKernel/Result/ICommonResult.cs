using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Result
{
    public interface ICommonResult
    {
        IEnumerable<string>? Errors { get; }

        bool IsSuccess { get; }

       ResultStatus Status { get; }
        object? GetValue();

    }

    public enum ResultStatus
    {
        Ok,
        Error,
        Forbidden,
        Unauthorized,
        NotFound,
        Invalid
    }
}
