using TaskTracker.DTO;

namespace TaskTracker.Services;

public interface ITaskTracker
{
    Task<List<T>> Get<T>();
    Task<List<T>> GetById<T>(int id);
    Task Create<T>(T model);
    Task Update<T>(T model);
    Task Delete<T>(int id);
}