using Microsoft.EntityFrameworkCore;
using TaskTracker.Data;
using TaskTracker.DTO;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.Repository;

public class ProjectTaskRepository : IProjectTaskRepository
{
    private readonly TaskTrackerContext _context;

    public ProjectTaskRepository(TaskTrackerContext context)
    {
        _context = context; 
    }

    public async Task<List<ProjectTaskDTO>> GetTask()
    {
        return await _context.ProjectTasks.ToListAsync();
    }
    
    
}