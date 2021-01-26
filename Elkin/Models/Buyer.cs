using System.ComponentModel.DataAnnotations;

namespace Elkin.Models
{
    public class Buyer
    {
        [Key]
        public int ID_buyer { get; set; }
        public string Last_name { get; set; }
        public string First_name { get; set; }
    }
}