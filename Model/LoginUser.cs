using System;
using System.Xml.Linq;

namespace LockBase_DMS_Service.Model
{
	public class LoginUser
    {
        public int Id {get; set;}

        public string Username {get; set;}


        public string Email {get; set;}


        public string Password {get; set;}


        public string Country_code {get; set;}


        public string Phone_number {get; set;}


        public DateTime CreateDate {get; set;}


        public DateTime UpdateDate {get; set;}


        public bool IsDeleted {get; set;}

    }
}

