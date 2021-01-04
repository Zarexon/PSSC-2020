using System;
using System.Linq;
using static Profile.Domain.CreateQuestionWorkflow.CreateQuestionResult;

namespace Question.Domain.CreateQuestionWorkflow
{
    public class UpdateQuestionVote
    {
        public QuestionPosted UpdateVote(QuestionPosted question, VoteEnum vote)
        {
            var votes = question.AllVotes;
            votes.Append(vote);

            //the score obtained from the votes must correspond to the sum of all the votes of the individual

            return new QuestionPosted(question.Title, question.Tags, votes.Sum(v=>Convert.ToInt32(v)), votes);
        }
    }
}
