using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.QuestionAggregate.Entites
{
    /// <summary>
    /// 回答表
    /// </summary>
    public class Answer:AuditWithUserEntity
    {
        private readonly List<AnswerLike> answerLikes=new List<AnswerLike>();

        public string Content { get; set; } = null!;

        public int QuestionId { get; set; }

        public Question Question { get; set; }= null!;

        public int LikeCount { get; set; }

        public int DisLikeCount { get; set; }

        /// <summary>
        /// => 这个是什么意思，不用=吗  to do...
        /// </summary>
        public IEnumerable<AnswerLike> AnswerLikes => answerLikes;

        /// <summary>
        /// 点赞或点踩
        /// </summary>
        /// <param name="like"></param>
        /// <returns></returns>
        public int AddLike(AnswerLike like)
        {
            if(like.IsLike)
            {
                LikeCount += 1;
            }
            else
            {
                DisLikeCount += 1;
            }
            answerLikes.Add(like);
            return LikeCount;
        }

        /// <summary>
        /// 取消点赞或取消点踩
        /// </summary>
        /// <param name="like"></param>
        /// <returns></returns>
        public int RemoveLike(AnswerLike like)
        {
            if (like.IsLike)
            {
                LikeCount -= 1;
            }
            else
            {
                DisLikeCount -= 1;
            }
            answerLikes.Remove(like);
            return LikeCount;
        }
    }
}
