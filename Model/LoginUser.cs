using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LockBase_DMS_Service.Model
{
    [Table("login_user")]
    public class LoginUser
    {
        [Key]
        [Column("pk_user_id")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("country_code")]
        public string CountryCode { get; set; }

        [Column("ph_number")]
        public string PhoneNumber { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("update_date")]
        public DateTime? UpdateDate { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

    }
}

