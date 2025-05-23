using Microsoft.EntityFrameworkCore;
using TaskTracker.Data;
using TaskTracker.DTO;
using TaskTracker.Models;

namespace TaskTracker.Repository;

public class ProjectRepository : IProjectRepository
{
    private readonly TaskTrackerContext _context;

    public ProjectRepository(TaskTrackerContext context)
    {
        _context = context; 
    }

    public async Task Create(ProjectDTO projectDto)
    {
        _context.Add(projectDto);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Project>> Get()
    {
        return await _context.Projects.ToListAsync();
    }

    public async Task Update(int id, ProjectDTO projectDto)
    {
        var project = await _context.Projects.SingleOrDefaultAsync(p => p.Id == id);
        project.Name = projectDto.Name;
        project.Description = projectDto.Description;
        await _context.SaveChangesAsync();
        
    }

    public async Task Delete(int id)
    {
        _context.Remove(await _context.Projects.FindAsync(id));
        await _context.SaveChangesAsync();
    }
}