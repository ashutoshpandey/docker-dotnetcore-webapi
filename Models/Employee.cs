using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
}