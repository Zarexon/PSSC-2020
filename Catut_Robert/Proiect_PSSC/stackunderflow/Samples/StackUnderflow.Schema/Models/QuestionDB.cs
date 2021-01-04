using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StackUnderflow.DatabaseModel.Models
{
    [Table("QuestionDB")]
    public class QuestionDB
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
    }
}
