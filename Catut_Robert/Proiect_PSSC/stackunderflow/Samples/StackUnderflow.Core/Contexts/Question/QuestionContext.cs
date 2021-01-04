using StackUnderflow.Domain.Core.Contexts.Question.LanguageOP;
using StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion;
using Access.Primitives.IO;
using static StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion.QuestionResult;
using static StackUnderflow.Domain.Core.Contexts.Question.LanguageOP.LanguageResult;
using System;
using static PortExt;

namespace StackUnderflow.Domain.Core.Contexts.Question
{
    public static class QuestionContext
    {
        public static Port<IQuestionResult> CreateQuestion(QuestionCmd questionCmd) => NewPort<QuestionCmd, IQuestionResult>(questionCmd);
        public static Port<ILanguageResult> CreateLanguage(LanguageCmd languageCmd) => NewPort<LanguageCmd, ILanguageResult>(languageCmd);
    }
}
