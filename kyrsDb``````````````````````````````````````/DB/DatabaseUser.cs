using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations.Schema;

namespace kyrsDb
{
    public class User
    {
        public string login = "";
        private bool isLoggedIn = false;
        private int isAdmin = -1;
        public int IsAdmin { get { return isAdmin; } }
        public bool IsLoggedIn { get { return isLoggedIn; } }
        public bool LogIn(string password, KyrsachContext context)
        {
            var cUser = from b in context.DbUsers
                        where b.Login == this.login
                        select b;
            if (cUser.First().Password == User.Hash(password))
            {
                isLoggedIn = true;
                isAdmin = cUser.First().CameraOwnerID;
                return true;
            }
            else 
            {
                return false;
            }
        }
        public User() { }
        public User(string log) 
        {
            login = log;
        }
        public static string Hash(string input)
        {
            byte[] hash;
            using (var sha256 = new SHA256CryptoServiceProvider())
                hash = sha256.ComputeHash(Encoding.Unicode.GetBytes(input));
            var sb = new StringBuilder();
            foreach (byte b in hash) sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }
    }
    public class DatabaseUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DatabaseUserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int CameraOwnerID { get; set; }
    }
    
}
