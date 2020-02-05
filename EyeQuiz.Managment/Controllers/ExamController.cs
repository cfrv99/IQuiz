using EyeQuiz.Managment.Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EyeQuiz.Managment.Controllers
{
    public class ExamController : Controller
    {
        private readonly DataContext context;

        public ExamController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Test(int? result)
        {
            var questions = context.Questions.ToList();
            ViewBag.Result = result;
            return View(questions);
        }

        [HttpPost]
        public ActionResult SetAnswer(List<string> answer)
        {

            var questions = context.Questions.ToList();

            int sum = 0;
            foreach (var question in questions)
            {
                foreach (var a in answer)
                {
                    if (question.CorrectAnswer == a)
                    {
                        sum = sum + 1;
                        break;
                    }
                }
            }

            
            return RedirectToAction("Test", new { result = sum });
        }
    }
}
