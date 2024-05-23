using Fitness.DataAccess.Repository.IRepository;
using Fitness.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace Fitness.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class ProgressController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProgressController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Customer/Progress/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Customer/Progress/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Progress progress)
        {
            if (ModelState.IsValid)
            {
                // Ustawiamy bieżącą datę
                progress.Date = DateTime.Now;

                // Pobieramy identyfikator użytkownika
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                progress.UserId = userId;

                //_unitOfWork.Progress.Add(progress);
                _unitOfWork.Save();

                TempData["success"] = "Wpis dziennika postępów został dodany.";
                return RedirectToAction(nameof(Index));
            }
            return View(progress);
        }

        // GET: /Customer/Progress/Index
        //public IActionResult Index()
        //{
        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var progressList = _unitOfWork.Progress.GetAll(u => u.UserId == userId);
        //    return View(progressList);
        //}
    }
}
