namespace MVC.Sneat.DAL.Entities
{
    public class Student:Entity
    {
        public string Name { get; set; } 
        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {GroupId} {Group?.Name}";
        }
    }
}
