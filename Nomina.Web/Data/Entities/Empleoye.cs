

namespace Nomina.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Empleoye : IEntity
    {
        public int Id { get; set; }

        [Key]
       public string NumDoc { get; set; }

        [Required]
        [Display(Name = "Document Type")]
        public int DocumentType { get; set; }

        [MaxLength(20)]
        [Required]
        [Display(Name = "Firts Name")]
        public string FirstName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Second Name")]
        public string SecondName { get; set; }

        [MaxLength(20)]
        [Required]
        [Display(Name = "First LastName")]
        public string FirstLastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Second Last Name")]
        public string SecondLastName { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Admission Date")]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Retirement Date")]
        public DateTime? RetirementDate { get; set; }

        [MaxLength(50)]
        public string Mail { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Salary { get; set; }
      
        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }
       
    }
}
