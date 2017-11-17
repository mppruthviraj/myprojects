using ABB_Portal.Models.ABBEntityModels.ABBModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB_Portal.Models.ABBEntityModels.ABBModels
{
    public class ABBTestimonials
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Headring Required")]
        public string Heading { get; set; }

        [Required(ErrorMessage = "Please Select a Category")]
        public ABB_Category Category { get; set; }

        [Required(ErrorMessage = "Please Select a Sub Category")]
        public ABB_SubCategory SubCategory { get; set; }

        [Required(ErrorMessage = "Please Select a Line Of Business")]
        public ABB_LineOfBusiness LineOfBusiness { get; set; }

        [Required(ErrorMessage = "Description Required")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State Required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please Select a Line Of Country")]
        public ABB_Country Country { get; set; }

        [Required(ErrorMessage = "Customer Required")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "Industry Required")]
        public string Industry { get; set; }

        [Required(ErrorMessage = "Customer Need Required")]
        [DataType(DataType.MultilineText)]
        public string CustomerNeed { get; set; }

        [Required(ErrorMessage = "ABBSoultion Required")]
        [DataType(DataType.MultilineText)]
        public string ABBSoultion { get; set; }

       
        public string ImageName { get; set; }



    }
}
