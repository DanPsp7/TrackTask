using TaskTracker.DTO;
using TaskTracker.Models;

namespace TaskTracker.Services;

public interface IProjectService
{
    Task<List<Project>> GetProject();
    //Task GetProjectById(int id);
    Task CreateProject(ProjectDTO projectDTO);
    Task UpdateProject(int id, ProjectDTO project);
    Task DeleteProject(int id);
}