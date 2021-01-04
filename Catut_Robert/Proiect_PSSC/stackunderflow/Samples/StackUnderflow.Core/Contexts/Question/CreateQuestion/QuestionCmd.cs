using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StackUnderflow.Domain.Core.Contexts.Question.CreateQuestion
{
    public class QuestionCmd
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Tag { get; set; }
        public QuestionCmd() { }
        public QuestionCmd(string Title,string Description,string Tag)
        {
            this.Title = Title;
            this.Description = Description;
            this.Tag = Tag;
        }
    }
}
