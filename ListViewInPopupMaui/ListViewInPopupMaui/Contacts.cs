﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewInPopupMaui
{
    public class Contacts : INotifyPropertyChanged
    {
        private string contactName;
        private string contactNumber;
        private string image;
        private string contactType;

        public Contacts(string name, string number)
        {
            contactName = name;
            contactNumber = number;
        }

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

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public string ContactImage
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.RaisedOnPropertyChanged("ContactImage");
            }
        }

        public string ContactType
        {
            get { return this.contactType; }
            set
            {
                this.contactType = value;
                this.RaisedOnPropertyChanged("ContactType");
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
