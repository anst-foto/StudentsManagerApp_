using System.Collections.Generic;

namespace StudentsManagerApp_.Models;

public class Student
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string FullName => $"{LastName} {FirstName}";
    
    public ICollection<Mark> Marks { get; set; }
}