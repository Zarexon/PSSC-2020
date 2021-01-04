using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StackUnderflow.Domain.Core.Contexts.Question.LanguageOP
{
    public class LanguageCmd
    {
        [Required]
        public string Text { get; }
        public LanguageCmd(string text)
        {
            Text = text;
        }
    }
}
