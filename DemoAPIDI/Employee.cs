namespace DemoAPIDI
{
    public interface IEmployee
    {
        public string? name { get; set; }
        public string? Description { get; set; }
    }
    public class Employee : IEmployee
    {
        public string? name { get; set; }
        public string? Description { get; set; }
    }
}
