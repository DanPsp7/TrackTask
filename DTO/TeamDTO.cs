namespace TaskTracker.DTO;

public class TeamDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public int? ProjectId { get; set; }
    public ProjectDTO? Project { get; set; }

    public virtual ICollection<UserDTO> UsersDTO { get; set; } = new List<UserDTO>();

}