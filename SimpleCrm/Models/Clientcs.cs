using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Clientcs:DomainObject
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstNote { get; set; }
        public string SecondNote { get; set; }
        public string GetFullName
        {
            get
            {
                string result = LastName;
                result += $" {FirstName}";
                result += $" {SecondName}";
                return result;
            }
        }
    }
}
