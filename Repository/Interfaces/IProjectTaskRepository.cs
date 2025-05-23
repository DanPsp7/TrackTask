using TaskTracker.DTO;

namespace TaskTracker.Repository.Interfaces;

public interface IProjectTaskRepository
{
    Task<List<ProjectTaskDTO>> GetTask();
    
    Task CreateTask(ProjectTaskDTO taskDto);
    
    Task UpdateTask(int id, ProjectTaskDTO taskDto);
    
    Task DeleteTask(int id);
}