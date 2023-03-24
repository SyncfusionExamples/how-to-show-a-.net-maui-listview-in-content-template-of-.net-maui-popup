using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupMAUI
{
    public class Contacts : INotifyPropertyChanged
    {
        private string contactName;        
        private string contactimage;      
    
        public Contacts()
        {
        }
        
        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }        

        public string ContactImage
        {
            get { return this.contactimage; }
            set
            {
                this.contactimage = value;
                this.RaisedOnPropertyChanged("ContactImage");
            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}
