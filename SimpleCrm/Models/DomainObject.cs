using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Models
{
    [AddINotifyPropertyChangedInterface]
    public class DomainObject
    {
        public int Id { get; set; }
    }
}
