namespace StudentsManagerApp_.Models;

public class Mark
{
    public int Id { get; set; }
    public int Value { get; set; }
    public string Teacher { get; set; }
    public string Subject { get; set; }
    
    public int StudentId { get; set; }
    public Student Student { get; set; }
}