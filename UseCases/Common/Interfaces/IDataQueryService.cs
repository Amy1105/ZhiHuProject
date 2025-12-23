using Core.AppUserAggregate.Entites;
using Core.QuestionAggregate.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.Common.Interfaces
{
    public interface IDataQueryService
    {
        public IQueryable<AppUser> AppUsers { get; }

        public IQueryable<FollowQuestion> FollowQuestions { get; }

        public IQueryable<FollowUser> FollowUsers { get; }

        public IQueryable<Question> Questions { get; }

        public IQueryable<Answer> Answers { get; }

        public IQueryable<AnswerLike> AnswersLikes { get; }

        Task<T?> FirstOrDefaultAsync<T> (IQueryable<T> query) where T : class;

        Task<IList<T>> ToListAsync<T> (IQueryable<T> queryable) where T : class;

        Task<bool> AnyAsync<T> (IQueryable<T> queryable) where T: class;
    }
}
