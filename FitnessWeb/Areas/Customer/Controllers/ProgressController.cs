using Fitness.DataAccess.Repository.IRepository;
using Fitness.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var progressList = _unitOfWork.Progress.GetAll(p => p.UserId == userId);
            return View(progressList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Progress progress)
        {
            if (!ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

                progress.UserId = userId;
                progress.Date = DateTime.Now;

                _unitOfWork.Progress.Add(progress);
                _unitOfWork.Save();

                return RedirectToAction(nameof(Index));
            }

            return View(progress);
        }
    }
}
