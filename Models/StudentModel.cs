using System.ComponentModel.DataAnnotations;
namespace Unit4MvcApp.Models;

public class StudentModel
{
        public StudentModel(int id, string name, int credits)
        {
            Id = id;
            Name = name;
            Credits = credits;
        }

        public StudentModel()
        {

        }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Credits { get; set; }
}