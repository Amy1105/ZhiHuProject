using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Result
{
    public class Result<T>:ICommonResult
    {
        public T? Value { get; init; }

        public  ResultStatus Status { get; protected set; }
        protected internal Result(T value)
        { 
        Value = value;
        }

        protected internal Result(ResultStatus status)
        {
            Status = status;
        }

        public bool IsSuccess => Status == ResultStatus.Ok;

        public IEnumerable<string>? Errors { get; protected set; }

        public object? GetValue()
        {
            return Value;
        }

        /// <summary>
        /// 当你有一个 Result 对象时，可以自动把它当作 Result<T> 来用，而不需要显式转换
        /// </summary>
        /// <param name="result"></param>
        public static implicit operator Result<T>(Result result)
        {
            return new Result<T>(default(T))
            {
                Status = result.Status,
                Errors = result.Errors
            };
        }
    }

    public class Result:Result<Result>
    {
        protected internal Result(Result value) : base(value) { }

        protected internal Result(ResultStatus status) : base(status) { }

        public static Result Success()
        {
            return new Result(ResultStatus.Ok);
        }

        public static Result<T> Success<T>(T value)
        {
            return new Result<T>(value);
        }

        public static Result Failure()
        {
            return new Result(ResultStatus.Error);
        }

        public static Result Failure(params string[] errors)
        {
            return new Result(ResultStatus.Error)
            {
                Errors = errors
            };
        }

        public static Result NotFound()
        {
            return new Result(ResultStatus.NotFound);
        }

        public static Result NotFound(params string[] errors)
        {
            return new Result(ResultStatus.NotFound)
            {
                Errors = errors
            };
        }

        public static Result Forbidden()
        {
            return new Result(ResultStatus.Forbidden);
        }

        public static Result Unauthorized()
        {
            return new Result(ResultStatus.Unauthorized);
        }

        public static Result Invalid()
        {
            return new Result(ResultStatus.Invalid);
        }

        public static Result Invalid(params string[] errors)
        {
            return new Result(ResultStatus.Invalid)
            {
                Errors = errors
            };
        }
    }
}
