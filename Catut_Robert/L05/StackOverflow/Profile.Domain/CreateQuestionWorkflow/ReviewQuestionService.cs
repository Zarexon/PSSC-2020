using System.Threading.Tasks;
using static Question.Domain.CreateQuestionWorkflow.Question;

namespace Question.Domain.CreateQuestionWorkflow
{
    public class ReviewQuestionService
    {
        public Task RewriteQuestionText(VerifiedQuestion question)
        {
            return Task.CompletedTask;
        }
    }
}
