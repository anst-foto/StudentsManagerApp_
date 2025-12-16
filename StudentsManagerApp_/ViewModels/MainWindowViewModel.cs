using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using StudentsManagerApp_.Models;

namespace StudentsManagerApp_.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly DataBaseContext _db;
    
    public ObservableCollection<Student> Students { get; } = [];
    
    public ICommand LoadCommand { get; }

    public MainWindowViewModel()
    {
        _db = new DataBaseContext();

        LoadCommand = new LambdaCommand(_ =>
        {
            var students = _db.Students
                .Include(s => s.Marks)
                .ToList();
        
            Students.Clear();
            foreach (var student in students)
            {
                Students.Add(student);
            }
        });
    }
}