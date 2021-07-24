using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowVModels:BaseVModels
    {
        public BaseVModels CurrentVModels { get; set; }
        public MenuVModels _menuVModels { get; set; }
        public MainWindowVModels()
        {
            _menuVModels = new MenuVModels();
            CurrentVModels = _menuVModels;
        }

    }
}
