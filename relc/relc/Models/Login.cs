using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using relc.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace relc.Models
{
    public enum LoginType
    {
        Unknown = 0,
        Teacher = 1,
        Student = 2,
        Other = 9,
    }

    public class Login
    {
        public Login()
        {
            
        }

        public Login(
            string username, 
            string password, 
            LoginType type,
            string nameFirst,
            string nameLast)
        {
            Username = username;
            //Password = password;
            PasswordHash(password);
            Type = type;
            NameFirst = nameFirst;
            NameLast = nameLast;
        }

        public Login(
            int id,
            string username, 
            string password,
            LoginType type,
            string nameFirst,
            string nameLast) : this(username, password, type, nameFirst, nameLast)
        {
            LoginId = id;
        }

        public int LoginId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        [JsonIgnore]
        public string Password { get; set; }

        [Required]
        public LoginType Type { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string NameFirst { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string NameLast { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        public IList<Attempt> Attempts { get; set; }

        public bool PasswordCompare(string password)
        {
            return PasswordHasher.VerifyHashedPassword(Password, password);
        }

        public void PasswordHash(string password)
        {
            Password = PasswordHasher.HashPassword(password);
        }
    }
}
