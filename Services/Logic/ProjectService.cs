using TaskTracker.DTO;
using TaskTracker.Models;
using TaskTracker.Repository;

namespace TaskTracker.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task CreateProject(ProjectDTO projectDto)
    {
        await _projectRepository.Create(projectDto);
    }
    
    public async Task<List<Project>> GetProject()
    {
        return await _projectRepository.Get() ;
    }

    public async Task UpdateProject(int id, ProjectDTO projectDto)
    {
        await _projectRepository.Update(id, projectDto);
    }

    public async Task DeleteProject(int id)
    {
        await _projectRepository.Delete(id);
    }
    
}