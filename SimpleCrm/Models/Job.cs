using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Job:DomainObject
    {
        public string StandartPrice { get; set; }
        public string Title { get; set; }
    }
}
