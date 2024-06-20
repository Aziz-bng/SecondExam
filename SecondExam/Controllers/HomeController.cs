using Microsoft.AspNetCore.Mvc;
using SecondExam.Models;
using SecondExam.Data;

using System.Diagnostics;
using System;
using Microsoft.EntityFrameworkCore;

namespace SecondExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SecondExamDBContext _context;

        public HomeController(ILogger<HomeController> logger, SecondExamDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var ExamList = _context.Exam
                           .Include(e => e.Questions).ThenInclude(q => q.Answers).ToList();

            return View(ExamList);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            

            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
