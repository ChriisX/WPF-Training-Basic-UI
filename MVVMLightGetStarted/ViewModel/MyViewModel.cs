using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightGetStarted.ViewModel
{
    public class MyViewModel : ViewModelBase
    {
        private string _myText = "Hello, World!";

        public string MyText
        {
            get
            {
                return _myText;
            }
            set
            {
                if (_myText == value)
                {
                    return;
                }

                _myText = value;

                RaisePropertyChanged("MyText");
            }
        }
    }
}
