namespace TaskTracker.DTO
{
    public class ProjectDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<ProjectTaskDTO> ProjectTasksDTO { get; set; } = new List<ProjectTaskDTO>();

        public virtual ICollection<TeamDTO> TeamsDTO { get; set; } = new List<TeamDTO>();
    }
}