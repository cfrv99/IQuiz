using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeQuiz.Managment.Entites
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExamTime { get; set; }
        public List<Question> Questions { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
