using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Order:DomainObject
    {
        public double Price { get; set; }
        public double JobTitle { get; set; }
        public State State { get; set; }
        public string StatusWork
        {
            get
            {
                switch (State)
                {
                    case State.Queue:
                        return "Queue";
                    case State.InProgress:
                        return "Performed";
                    case State.Done:
                        return "Done";
                    default:
                        return "Unknown";
                }
            }
        }
    }
}
