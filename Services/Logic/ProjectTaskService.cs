using TaskTracker.DTO;

namespace TaskTracker.Services;

public class ProjectTaskService
{
    private readonly IProjectTaskService _projectTaskService;

    public ProjectTaskService(IProjectTaskService projectTaskService)
    {
        _projectTaskService = projectTaskService;
    }

    public async Task<List<ProjectTaskDTO>> GetTask()
    {
    }
    
    public async Task CreateTask(ProjectTaskDTO taskDto)
    {
    }
    
    public async Task UpdateTask (int id, ProjectTaskDTO taskDto)
    {
    }
    
    public async Task DeleteTask(int id)
    {
    }
}