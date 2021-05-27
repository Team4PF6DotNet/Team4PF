using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PsAspNETCoreDemo.Interface.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsAspNETCoreDemo.Controllers
{
    public class ProjectCreatorController : Controller
    {
        private readonly IProjectCreatorService _service;

        public ProjectCreatorController(IProjectCreatorService service)
        {
            _service = service;
        }
        // GET: ProjectCreatorController
        public async Task<ActionResult> Index()
        {

            return View(await _service.GetAll());
        }

        // GET: ProjectCreatorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProjectCreatorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectCreatorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectCreatorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProjectCreatorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectCreatorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProjectCreatorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
