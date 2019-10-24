using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using MySql.Data.MySqlClient;

namespace MyProject.Controllers
{
    public class UserController:Controller
    {
        public IActionResult OrderPlaced()
        {
            return View();
        }
        private MySqlConnection createConnection()
        {
            string connection = "server=localhost;database=myproject_db;user=root;password=Elect30@4;port=3306";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            return con;
        }

        public IActionResult Register()
        {
            ViewData["registrationSuccessfull"] = false;
            ViewData["error"] = false;
            return View();
        }

        [HttpPost]
        public IActionResult Register(User _user )
        {
            UsersPad _newUserPad = new UsersPad();
            _newUserPad.RegisterUser(_user);
            ViewData["registrationSuccessfull"] = true;
            ViewData["error"] = false;
            return View();
        }

        // function to execute when login button is clicked
        public IActionResult Login()
        {
            ViewData["error"] = false;
            ViewData["loginSuccessfull"] = false;
            ViewData["userNotFound"] = false;
            return View();
        }
        // function to execute when logout button is clicked
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // clearout the session
            return Redirect("/user/login");
        }
        [HttpPost]
        // function to execute when user submits the login form
        public IActionResult Login(string email, string password)
        {
            try
            {
            var con = this.createConnection(); // call the connection function to get the connection
            string cmdText = $"select * from users where userEmail = '{email}' and userPassword = '{password}';"; // creating the query
            MySqlCommand cmd = new MySqlCommand(cmdText, con); // creating the mysql command
            var userEmail = email;
            var result = cmd.ExecuteReader(); // executing the query
            if(result.HasRows) // check whether query result has any rows or not
            {
                HttpContext.Session.SetString("user", userEmail); // setting the the session in HttpContext
                ViewData["error"] = false;
                ViewData["loginSuccessfull"] = true;
                ViewData["userNotFound"] = false;
                return View();
            }
            else
            {
                ViewData["error"] = false;
                ViewData["loginSuccessfull"] = false;
                ViewData["userNotFound"] = true;
                return View();
            }
            }
            catch(Exception exception)
            {
            ViewData["error"] = true;
            ViewData["loginSuccessfull"] = false;
            ViewData["userNotFound"] = false;
            return View();
            }
        }
    }
}
