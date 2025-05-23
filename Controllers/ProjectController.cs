using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskTracker.Models;
using TaskTracker.Data;
using TaskTracker.DTO;
using TaskTracker.Models;
using TaskTracker.Services;


namespace TaskTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {

        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        [Route("Get")]
        [Produces("application/json")]
        public async Task<List<Project>> Get(int id)
        {
            return await _projectService.GetProject();
        }


        [HttpPost]
        [Route("Create")]
        public async Task Create(ProjectDTO projectDTO)
        {
            await _projectService.CreateProject(projectDTO);
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(int id, ProjectDTO projectDto)
        {
            await _projectService.UpdateProject(id ,projectDto);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await _projectService.DeleteProject(id);
        }
        
        // POST: Project/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [Route("Create")]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("Name,Description")] ProjectDTO project)
        // {
        //     
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(project);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(project);
        // }
        //
        // // POST: Project/Edit/5
        // // To protect from overposting attacks, enable the specific properties you want to bind to.
        // // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPut]
        // [Route("Edit")]
        // public async Task<IActionResult> UpdateProject(int id, [Bind("Name,Description")] Project project)
        // {
        //     if (id != project.Id)
        //     {
        //         return NotFound();
        //     }
        //
        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(project);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!ProjectExists(project.Id))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(project);
        // }
        //
        // // POST: Project/Delete/5
        // [HttpPost, ActionName("Delete")]
        // [Route("Delete")]
        // public async Task<IActionResult> DeleteConfirmed(int id)
        // {
        //     var project = await _context.Projects.FindAsync(id);
        //     if (project != null)
        //     {
        //         _context.Projects.Remove(project);
        //     }
        //
        //     await _context.SaveChangesAsync();
        //     return RedirectToAction(nameof(Index));
        // }
        //
        // private bool ProjectExists(int id)
        // {
        //     return _context.Projects.Any(e => e.Id == id);
        // }
    }
}