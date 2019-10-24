using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace MyProject.Models
{
    public class User
    {
        public int userId {get; set;}
        public string userName {get; set;}
        public string userEmail {get; set;}
        public string userPassword {get; set;}
        public string userAddress{get; set;}
    }
}
