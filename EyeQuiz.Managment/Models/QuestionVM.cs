using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeQuiz.Managment.Models
{
    public class QuestionVM
    {
        
        public string QuestionName { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public int Point { get; set; }
        public string CorrectVariant { get; set; }

    }
}
