using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task4_userAPI.Models
{
    public class user
    {
        [Key]
        public int Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
    }
}
