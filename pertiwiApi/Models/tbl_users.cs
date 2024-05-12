using System.ComponentModel.DataAnnotations;

namespace pertiwiApi.Models
{
    public class tbl_users
    {
        [Key]
        public int ID { get; set; }

        public string type_user { get; set; }

        public string nama { get; set; }

        public string alamat { get; set; }

        public string username { get; set; }

        public string password { get; set; }
    }
}
