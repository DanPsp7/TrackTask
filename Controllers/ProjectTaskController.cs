using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskTracker.Models;
using TaskTracker.Data;



public class Request
{
    public int Id { get; set; }
}

namespace TrackTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectTaskController : Controller
    {
        private readonly TaskTrackerContext _context;

        public ProjectTaskController(TaskTrackerContext context)
        {
            _context = context;
        }

        // POST: ProjectTask/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Status,SpentTime,UserId,ProjectId")] ProjectTask projectTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", projectTask.ProjectId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", projectTask.UserId);
            return View(projectTask);
        }

        // POST: ProjectTask/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Status,SpentTime,UserId,ProjectId")] ProjectTask projectTask)
        {
            if (id != projectTask.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectTaskExists(projectTask.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", projectTask.ProjectId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", projectTask.UserId);
            return View(projectTask);
        }

        // POST: ProjectTask/Delete/5
        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> DeleteConfirmed([FromBody]Request request)
        {
            var projectTask = await _context.ProjectTasks.FindAsync(request.Id);
            if (projectTask != null)
            {
                _context.ProjectTasks.Remove(projectTask);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectTaskExists(int id)
        {
            return _context.ProjectTasks.Any(e => e.Id == id);
        }

       
    }
}