using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST2.Models
{
        [Table("logpas")]
        public class LoginPassword
        {
            [Key]
            public int Id { get; set; }
            public string login { get; set; }
            public string password { get; set; }
        }

        [Table("organizations")]
        public class Organization
        {
            [Key]
            public int Id { get; set; }
            public string Organizations { get; set; }
        }

        [Table("jobtitle")]
        public class JobTitle
        {
            [Key]
            public int Id { get; set; }
            public string JobTitles { get; set; }
            public int ORG_ID { get; set; }

            [ForeignKey("ORG_ID")]
            public virtual Organization Organization { get; set; }
        }

        [Table("lvl_access")]
        public class AccessLevel
        {
            [Key]
            public int Id { get; set; }
            public int LVL { get; set; }
            public int JobTitle_ID { get; set; }

            [ForeignKey("JobTitle_ID")]
            public virtual JobTitle JobTitle { get; set; }
        }

        [Table("users")]
        public class User
        {
            [Key]
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public long Number { get; set; }
            public int Login_password_ID { get; set; }
            public int LvL_ID { get; set; }

            [ForeignKey("Login_password_ID")]
            public virtual LoginPassword LoginPassword { get; set; }

            [ForeignKey("LvL_ID")]
            public virtual AccessLevel AccessLevel { get; set; }
        }
}

    