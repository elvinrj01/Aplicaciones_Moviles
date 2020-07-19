using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Model.ViewModels.Controls.Inputs
{
    public class PersonalInformationInputDTO
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Range(1, 9, ErrorMessage = "Invalid value")]
        [StringLength(4, ErrorMessage = "Max 4 digits")]
        [Required(ErrorMessage = "Birth year is required")]
        public int BirthDate { get; set; }
        [Required(ErrorMessage = "Birth Place is required")]
        public string BirthPlace { get; set; }
        [Required(ErrorMessage = "Marital status is required")]
        public string MaritalStatus { get; set; }
        [Required(ErrorMessage = "Mayor is required")]
        public string Mayor { get; set; }
    }
}
