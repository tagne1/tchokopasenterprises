using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TchokopassEnterprises4.ViewModels
{
    public class EmailModel
    {
        
        public EmailModel(string name, string phonenumber, string email, string subject, string message)
        {
            this.Name = name;
            this.Phonenumber = phonenumber;
            this.Email = email;
            this.Subject = subject;
            this.Message = message;
           
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }

    }
}

