using System;

namespace Question.Domain.CreateQuestionWorkflow
{
    [Serializable]
    public class InvalidQuestionException : Exception
    {
        public InvalidQuestionException()
        { }

        public InvalidQuestionException(string question) : base($"The value \"{question}\" is an invalid question format.")
        { }
    }
}
