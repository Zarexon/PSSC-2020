using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUnderflow.Domain.Core.Contexts.Question.LanguageOP
{
    [AsChoice]
    public static partial class LanguageResult
    {
        public interface ILanguageResult { }

        public class ValidationOK:ILanguageResult
        {
            public string Text { get; }
            public ValidationOK(string text)
            {
                Text = text;
            }
        }
        public class ValidationNotOK:ILanguageResult
        {
            public string Message { get; }
            public ValidationNotOK(string message)
            {
                Message = message;
            }
        }
    }
}
