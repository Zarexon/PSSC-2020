﻿using System;
using System.Collections.Generic;

namespace Question.Domain.CreateQuestionWorkflow
{
    [Serializable]
    public class InvalidQuestionTagsException : Exception
    {
        public InvalidQuestionTagsException()
        { }

        public InvalidQuestionTagsException(List<string> tags) : base($"The value \"{tags.Count}\" is an invalid question format. Please don't enter more than three tags!")
        { }
    }
}
