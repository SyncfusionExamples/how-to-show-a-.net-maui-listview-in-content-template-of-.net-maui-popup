
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupMAUI
{
    public class ContactsViewModel : INotifyPropertyChanged
    {
        #region Properties

        public ObservableCollection<Contacts> Items { get; set; }

        #endregion

        #region Constructor

        public ContactsViewModel()
        {
            Random random = new Random(123456789);
            Items = new ObservableCollection<Contacts>();

            for (int i = 0; i < CustomerNames.Count(); i++)
            {
                var contact = new Contacts();
                contact.ContactName = CustomerNames[i];
                contact.ContactImage = "image" + random.Next(0, 28) + ".png";                
                Items.Add(contact);
            }
        }

        #endregion

        #region Fields

        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson",
            "Mason",
            "Liam",
            "Jacob",
            "Jayden",
            "Ethan",
            "Noah",
            "Lucas",
            "Logan",
            "Caleb",
            "Caden",
            "Jack",
            "Ryan",
            "Connor",
            "Michael",
            "Elijah",
            "Brayden",
            "Benjamin",
            "Nicholas",
            "Alexander",
            "William",
            "Matthew",
            "James",
            "Landon",
            "Nathan",
            "Dylan",
            "Evan",
            "Luke",
            "Andrew",
            "Gabriel",
            "Gavin",
            "Joshua",
            "Owen",
            "Daniel",
            "Carter",
            "Tyler",
            "Cameron",
            "Christian",
            "Wyatt",
            "Henry",
            "Eli",
            "Joseph",
            "Max",
            "Isaac",
            "Samuel ",
            "Anthony",
            "Grayson",
            "Zachary",
            "David",
            "Christopher",
            "John",
            "Isaiah",
            "Levi",
            "Jonathan",
            "Oliver",
            "Chase",
            "Cooper",
            "Tristan",
            "Colton",
            "Austin",
            "Colin",
            "Charlie",
            "Dominic",
            "Parker ",
            "Hunter",
            "Thomas",
            "Alex",
            "Ian",
            "Jordan",
            "Cole",
            "Julian",
            "Aaron",
            "Carson",
            "Miles",
            "Blake",
            "Brody",
            "Adam",
            "Sebastian" ,
            "Adrian",
            "Nolan",
            "Sean",
            "Riley",
            "Bentley",
            "Xavier ",
            "Hayden",
            "Jeremiah",
            "Jason",
            "Jake",
            "Asher",
            "Micah",
            "Jace",
            "Brandon",
            "Josiah",
            "Hudson",
            "Nathaniel",
            "Bryson",
            "Ryder",
            "Justin",
            "Bryce",
        };

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
