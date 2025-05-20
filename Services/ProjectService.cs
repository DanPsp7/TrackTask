using TaskTracker.Models;
using TaskTracker.Repository;

namespace TaskTracker.Services;

public class ProjectService : ITaskTracker
{
    public async Task<List<Project>> Get()
    {
        return await ProjectRepository.Read();
    }
}