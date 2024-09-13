namespace MVC.Sneat.DAL.Entities
{
    public class Group:Entity 
    {
        public string? Name { get; set; }
        public ICollection<Student>? Students { get; set; } = new List<Student>();
        public ICollection<TeacherGroup> teacherGroups { get; set; } = new List<TeacherGroup>();
    }
}
