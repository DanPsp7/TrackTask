using TaskTracker.DTO;

namespace TaskTracker.Services;

public interface IProjectTaskService
{
    Task<List<ProjectTaskDTO.ProjectTask>> GetTask();
    //Task GetProjectById(int id);
    Task CreateTask(ProjectTaskDTO projectTaskDto);
    Task UpdateTask(int id, ProjectDTO projectTaskDto);
    Task DeleteTask(int id);
}