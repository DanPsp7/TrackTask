using TaskTracker.DTO;

namespace TaskTracker.Services;

public interface ITeamService
{
    Task<List<TeamDTO>> GetTeam();
    //Task GetProjectById(int id);
    Task CreateTeam(TeamDTO teamDto);
    Task UpdateTeam(int id, TeamDTO teamDto);
    Task DeleteTeam(int id);
}