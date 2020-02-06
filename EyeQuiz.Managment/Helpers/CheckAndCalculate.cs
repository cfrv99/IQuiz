using EyeQuiz.Managment.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EyeQuiz.Managment.Helpers
{
    public static class CheckAndCalculate
    {
        public static int CheckAndCalculateMethod(List<Question> questions, List<string> answers)
        {
            int sum = 0;
            foreach (var question in questions)
            {
                foreach (var answer in answers)
                {
                    if (question.CorrectAnswer == answer)
                    {
                        sum = sum + question.Point;
                        break;
                    }
                }
            }

            return sum;
        }
    }
}
