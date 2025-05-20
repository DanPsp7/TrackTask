using System.ComponentModel.DataAnnotations.Schema;
using TaskTracker.Models;

namespace TaskTracker.DTO;

public class ProjectTaskDTO
{
    public enum TaskStatus
    {
        Free,       // Задача свободна
        Working,    // В работе
        Done,       // Завершена
        Paused,     // Приостановлена
        Cancelled   // Отменена
    }


    public class ProjectTask

    {
        public string? Name { get; set; }
        public string? Description { get; set; }
                
        public TaskStatus Status {  get; set; }

        [Column(TypeName = "time")]
        public TimeSpan SpentTime { get; set; }

        public UserDTO? UserDTO { get; set; }
        public int? UserDTOId { get; set; }


        public ProjectDTO ProjectDTO { get; set; } = new ProjectDTO(); 
        public int ProjectDTOId { get; set; }

        
    }

}