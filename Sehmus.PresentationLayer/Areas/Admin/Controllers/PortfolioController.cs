﻿using Microsoft.AspNetCore.Mvc;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;

namespace Sehmus.PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        // GET: PortfolioController
        public ActionResult Index()
        {
            var resultList = _portfolioService.GetPortfolioListManager();
            return View(resultList);
        }

        // GET: PortfolioController/Create
        public ActionResult Create()
        {
            ViewBag.dgr = _portfolioService.UserListManager();
            return View();
        }

        // POST: PortfolioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Portfolio portfolio, IFormFile? ImageUrl1, IFormFile? ImageUrl2, IFormFile? ImageUrl3, IFormFile? ImageUrl4)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (ImageUrl1 is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl1.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrl1.CopyTo(stream1);
                        portfolio.ImageUrl1 = ImageUrl1.FileName;
                    }
                    if (ImageUrl2 is not null)
                    {
                        string klasor2 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl2.FileName;
                        using var stream2 = new FileStream(klasor2, FileMode.Create);
                        ImageUrl2.CopyTo(stream2);
                        portfolio.ImageUrl2 = ImageUrl2.FileName;
                    }
                    if (ImageUrl3 is not null)
                    {
                        string klasor3 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl3.FileName;
                        using var stream3 = new FileStream(klasor3, FileMode.Create);
                        ImageUrl3.CopyTo(stream3);
                        portfolio.ImageUrl3 = ImageUrl3.FileName;
                    }
                    if (ImageUrl4 is not null)
                    {
                        string klasor4 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl4.FileName;
                        using var stream4 = new FileStream(klasor4, FileMode.Create);
                        ImageUrl4.CopyTo(stream4);
                        portfolio.ImageUrl4 = ImageUrl4.FileName;
                    }
                    _portfolioService.Add(portfolio);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PortfolioController/Edit/5
        public ActionResult Edit(int id)
        {
            var resultDataId = _portfolioService.GetByID(id);
            return View(resultDataId);
        }

        // POST: PortfolioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Portfolio portfolio, IFormFile? ImageUrl1, IFormFile? ImageUrl2, IFormFile? ImageUrl3, IFormFile? ImageUrl4)
        {
            try
            {
                if (!ModelState.IsValid)
                {    
                        if (ImageUrl1 is not null)
                        {
                            string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl1.FileName;
                            using var stream1 = new FileStream(klasor1, FileMode.Create);
                            ImageUrl1.CopyTo(stream1);
                            portfolio.ImageUrl1 = ImageUrl1.FileName;
                        }
                        if (ImageUrl2 is not null)
                        {
                            string klasor2 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl2.FileName;
                            using var stream2 = new FileStream(klasor2, FileMode.Create);
                            ImageUrl2.CopyTo(stream2);
                            portfolio.ImageUrl2 = ImageUrl2.FileName;
                        }
                        if (ImageUrl3 is not null)
                        {
                            string klasor3 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl3.FileName;
                            using var stream3 = new FileStream(klasor3, FileMode.Create);
                            ImageUrl3.CopyTo(stream3);
                            portfolio.ImageUrl3 = ImageUrl3.FileName;
                        }
                        if (ImageUrl4 is not null)
                        {
                            string klasor4 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl4.FileName;
                            using var stream4 = new FileStream(klasor4, FileMode.Create);
                            ImageUrl4.CopyTo(stream4);
                            portfolio.ImageUrl4 = ImageUrl4.FileName;
                        }
                        _portfolioService.Update(portfolio);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PortfolioController/Delete/5
        public ActionResult Delete(int id)
        {
            var resultDataId = _portfolioService.GetByID(id);
            return View(resultDataId);
        }

        // POST: PortfolioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Portfolio portfolio)
        {
            try
            {
                _portfolioService.Remove(portfolio);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
