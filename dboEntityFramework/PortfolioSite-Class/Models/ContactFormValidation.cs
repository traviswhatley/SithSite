using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add using statement for data annotations
using System.ComponentModel.DataAnnotations;

namespace PortfolioSite_Class.Models
{
    //add metadata type to contact form
    [MetadataType(typeof(ContactFormValidation))]
    public partial class ContactForm
    {
        //this is not the function you're looking for
    }

    public class ContactFormValidation
    {
        //data annotatinos handle the label display of our
        //fields and set requirements for valid data
        [Required(ErrorMessage="The master requires your name."), Display(Name="Your name")]
        public string Name { get; set; }

        [Display(Name="Company Name"), MaxLength(50)]
        public string CompanyName { get; set; }

        [Required(ErrorMessage="I must contact you."), EmailAddress(ErrorMessage="You must be weak you fool, you don't deserve the title of Sith.")]
        public string Email { get; set; }

        [Required(ErrorMessage="Prove your worth, if the master is impressed, we will find you."), DataType(DataType.MultilineText), MaxLength(144)]
        public string Comments { get; set; }
    }
}