using Microsoft.AspNetCore.Mvc;
using BusinessObjects;
using Services;
using System.Collections.Generic;

namespace FuNewsManagement.Controllers
{
    public class TagsController : Controller
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        // GET: Tags
        public IActionResult Index()
        {
            var tags = _tagService.GetTags();
            return View(tags);
        }

        // GET: Tags/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var tag = _tagService.GetTagById(id.Value);
            if (tag == null) return NotFound();

            return View(tag);
        }

        // GET: Tags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tags/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("TagId,TagName,Note")] Tag tag)
        {
            if (ModelState.IsValid)
            {
                _tagService.SaveTag(tag);
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }

        // GET: Tags/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var tag = _tagService.GetTagById(id.Value);
            if (tag == null) return NotFound();

            return View(tag);
        }

        // POST: Tags/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("TagId,TagName,Note")] Tag tag)
        {
            if (id != tag.TagId) return NotFound();

            if (ModelState.IsValid)
            {
                _tagService.UpdateTag(tag);
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }

        // GET: Tags/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var tag = _tagService.GetTagById(id.Value);
            if (tag == null) return NotFound();

            return View(tag);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var tag = _tagService.GetTagById(id);
            if (tag != null)
            {
                _tagService.DeleteTag(tag);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
