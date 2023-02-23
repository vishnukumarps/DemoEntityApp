using System.ComponentModel.DataAnnotations;
using System.Net;

namespace DemoEntityApp.Model;
public class Student
{
    [Key]
    public int Id { get; set; }

    [MaxLength(30)]
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public virtual Address Address { get; set; }

}

