using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyectoFinal.Models
{
    public class UserModel
    {
        //Model for Users
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }

        [MaxLength(16)]
        public string User { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(8)]
        public string Password { get; set; }
    }
}
