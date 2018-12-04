using System.ComponentModel.DataAnnotations;

namespace AjaxExample.Models
{
    public class Person
    {
        [Required]
        public string Name {get;set;}
        [Required]
        public string Location {get;set;}
    }
}