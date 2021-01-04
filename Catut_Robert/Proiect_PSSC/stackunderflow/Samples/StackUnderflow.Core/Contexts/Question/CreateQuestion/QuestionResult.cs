using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion
{
    [AsChoice]
    public static partial class QuestionResult
    {
        public interface IQuestionResult { }
        public class QuestionCreate : IQuestionResult
        {
            public int QuestionId { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Tag { get; set; }
            public QuestionCreate (int id,string title,string description,string tag)
            {
                QuestionId = id;
                Title = title;
                Description = description;
                Tag = tag;
            }
        }
        public class QuestionNotCreate:IQuestionResult
        {
            public string Text { get; }
            public QuestionNotCreate(string text)
            {
                text = text;
            }
        }
    }
}
