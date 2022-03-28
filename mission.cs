using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;    //  Az INotifyPropertyChanged névtere

namespace processManagement
{
    public class mission //: INotifyPropertyChanged
    {

        //public event PropertyChangedEventHandler? PropertyChanged;
        //public void onPropertyChanged(string tulajdonsagnev)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tulajdonsagnev));
        //}


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        private int startingMonth;

        public int StartingMonth
        {
            get { return startingMonth; }
            set { startingMonth = value; /*onPropertyChanged("StartingMonth");*/ }
        }

        private int startingDay;

        public int StartingDay
        {
            get { return startingDay; }
            set { startingDay = value; }
        }

        private int duration;

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private int endingMonth;

        public int EndingMonth
        {
            get { return endingMonth; }
            set { endingMonth = value; }
        }

        private int endingDay;

        public int EndingDay
        {
            get { return endingDay; }
            set { endingDay = value; }
        }


        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

    }
}
