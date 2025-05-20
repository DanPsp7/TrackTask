namespace TaskTracker.DTO;

public class UserDTO
{
    public int Id { get; set; }

        
    public string Name { get; set; } = null!;

    public int TeamId { get; set; }
    public TeamDTO Team { get; set; } = new TeamDTO();

 
    public ProjectTaskDTO? ProjectTasks { get; set; }
}