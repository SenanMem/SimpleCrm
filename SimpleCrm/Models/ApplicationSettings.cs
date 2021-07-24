using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Models
{
    [AddINotifyPropertyChangedInterface]
    public static class ApplicationSettings
    {
        public static string CompanyName = "Mem_CRM";
        public static string FirstNoteClient = "Заметка 1";
        public static string SecondNoteClient = "Заметка 2";
    }
}
