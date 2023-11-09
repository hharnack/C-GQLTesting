namespace C_GQLTesting.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Person
{
    public int Id { get; set; }
    [Display(Name = "First Name")]
    public string? FirstName { get; set; }
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }
    public int? Age { get; set; }
}