using EyeQuiz.Managment.Entites;
using EyeQuiz.Managment.Models;
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
        [HttpGet]
        public IActionResult Create()
        {
            return View(new QuestionVM());
        }

        [HttpPost]
        public IActionResult Create(QuestionVM vm)
        {
            if (ModelState.IsValid)
            {
                Question q = new Question
                {
                    QuestionName = vm.QuestionName,
                    AnswerA = vm.AnswerA,
                    AnswerB = vm.AnswerB,
                    AnswerD = vm.AnswerD,
                    AsnwerC = vm.AnswerC,
                    CorrectAnswer = vm.CorrectVariant,
                    Point=vm.Point
                };
                context.Questions.Add(q);
                
                var isSave = context.SaveChanges();
                if (isSave > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                throw new Exception("Database ex");

            }

            return View();
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
                        sum = sum + question.Point;
                        break;
                    }
                }
            }

            if (sum < 30)
            {
                TempData["Valid"] = "Siz Kesilmisiniz ";
            }
            else if (sum > 100)
            {
                TempData["Valid"] = "Elasan";
            }

                    
            return RedirectToAction("Test", new { result = sum });
        }
    }
}
