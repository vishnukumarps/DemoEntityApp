using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemoEntityApp.Model;

public class Address
{
    [Key]
    public int AddressId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }




    [ForeignKey("Id")]

    public int StudentId { get; set; }
    public virtual Student Student { get; set; }
}
