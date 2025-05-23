using TaskTracker.DTO;
using TaskTracker.Models;

namespace TaskTracker.Repository;

public interface IProjectRepository
{
    Task<List<Project>> Get();
    Task Create(ProjectDTO projectDto);
    Task Update(int id, ProjectDTO projectDto);
    Task Delete(int id);
}