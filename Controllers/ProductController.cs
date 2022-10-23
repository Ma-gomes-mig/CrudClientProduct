using Cadastro.Interfaces;
using Cadastro.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductViewModelService _productViewModelService;
        public ProductController(IProductViewModelService productViewModelService)
        {
            _productViewModelService = productViewModelService;
        }

        // GET: Product
        public ActionResult Index()
        {
            var list = _productViewModelService.GetAll();
            return View(list);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = _productViewModelService.Get(id);
            return View(viewModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel viewModel)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _productViewModelService.Insert(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = _productViewModelService.Get(id);
            return View(viewModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Update(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModel = _productViewModelService.Get(id);
            return View(viewModel);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Delete(id);

                    return RedirectToAction(nameof(Index));
                }

                var viewModel = _productViewModelService.Get(id);
                return View(viewModel);
            }
            catch
            {
                var viewModel = _productViewModelService.Get(id);
                return View(viewModel);
            }
        }
    }
}
