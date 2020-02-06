using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeQuiz.Managment.Entites
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionName { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AsnwerC { get; set; }
        public string AnswerD { get; set; }
        public int Point { get; set; }
        public string CorrectAnswer { get; set; }
        public int? ExamId { get; set; }
        public Exam Exam { get; set; }

    }
}
