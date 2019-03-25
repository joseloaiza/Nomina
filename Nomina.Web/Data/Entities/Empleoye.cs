using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nomina.Web.Data.Entities
{
    public class Empleoye
    {
        [Key]
        public string NumDoc { get; set; }

        [Display(Name = "Document Type")]
        public int DocumentType { get; set; }

        [Display(Name = "Firts Name")]
        public string FirstName { get; set; }

        [Display(Name = "Second Name")]
        public string SecondName { get; set; }

        [Display(Name = "First LastName")]
        public string FirstLastName { get; set; }

        [Display(Name = "Second Last Name")]
        public string SecondLastName { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Admission Date")]
        public DateTime AdmissionDate { get; set; }

        [Display(Name = "Retirement Date")]
        public DateTime RetirementDate { get; set; }
        
        public string Mail { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Salary { get; set; }
      
        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }



    }
}
