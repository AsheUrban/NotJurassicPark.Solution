// using System.ComponentModel.DataAnnotations;

namespace JurassicPark.Models
{
  public class Animal
  // {
  //     public int AnimalId { get; set; }
  //     [Required]
  //     [StringLength(20)]
  //     public string Name { get; set; }
  //     [Required]
  //     public string Species { get; set; }
  //     [Required]
  //     [Range(0, 200, ErrorMessage = "Age must be between 0 and 200.")]
  //     public int Age { get; set; }
  //     [Required]
  //     public string Gender { get; set; }
  // }

  {
    public int AnimalId { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public string Gender { get; set; }
  }
}