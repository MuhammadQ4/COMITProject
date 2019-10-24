using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MyProject.Models
{
    public class UsersPad
    {
        private MySqlConnection createConnection()
        {
            string connection = "server=localhost;database=myproject_db;user=root;password=Elect30@4;port=3306";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            return con;
        }
        public void RegisterUser(User _user)
        {
            List<User> usersList = new List<User>();
            var con = this.createConnection();
            string cmdTxt = $"INSERT INTO users(userName, userEmail, userPassword, userAddress) VALUES ('{_user.userName}','{_user.userEmail}','{_user.userPassword}','{_user.userAddress}');";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            cmd.ExecuteNonQuery();
            con.Close();
    }
    }
}