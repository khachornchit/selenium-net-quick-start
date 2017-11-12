using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium2016.Models
{
    public class InteressentInfo
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Nationality { get; set; }

        public InteressentInfo(string Language, string Title, string FirstName, string LastName, string Email, string Nationality)
        {
            this.Language = Language;
            this.Title = Title;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Nationality = Nationality;        
        }
    }
}