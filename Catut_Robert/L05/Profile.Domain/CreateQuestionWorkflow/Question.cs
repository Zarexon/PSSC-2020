using CSharp.Choices;
using LanguageExt.Common;
using System.Collections.Generic;


namespace Question.Domain.CreateQuestionWorkflow
{
    [AsChoice]
    public static partial class Question
    {
        public interface IQuestion { }

        public class UnverifiedQuestion : IQuestion
        {
            public string Question { get; private set; }
            public List<string> Tags { get; private set; }
            private UnverifiedQuestion(string question, List<string> tags)
            {
                Question = question;
                Tags = tags;
            }

            public static Result<UnverifiedQuestion> Create(string question, List<string> tags)
            {
                if (IsQuestionValid(question) && IsTagsValid(tags))
                {
                    return new UnverifiedQuestion(question, tags);
                }
                else if (!IsQuestionValid(question))
                {
                    return new Result<UnverifiedQuestion>(new InvalidQuestionException(question));
                }
                else 
                {
                    return new Result<UnverifiedQuestion>(new InvalidQuestionTagsException(tags));
                }
            }

            public static bool IsQuestionValid(string question)
            {
               
                if (question.Length <= 1000)
                {
                   
                    return true;
                }
                return false;
            }

            public static bool IsTagsValid(List<string> tags)
            {
                
                if (tags.Count>=1 && tags.Count<=3)
                {
                    return true;
                }
                return false;
            }
        }
        
        public class VerifiedQuestion : IQuestion
        {
            public string Question { get; private set; }
            public List<string> Tags { get; private set; }

            internal VerifiedQuestion(string question, List<string> tags)
            {
                Question = question;
                Tags = tags;
            }
        }
    }
}
