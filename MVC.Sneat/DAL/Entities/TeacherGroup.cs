namespace MVC.Sneat.DAL.Entities
{
    public class TeacherGroup: Entity
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
