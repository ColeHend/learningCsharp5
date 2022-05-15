using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace learningCsharp5
{
    public class Addition : INotifyPropertyChanged
    {
        private string num1;
        private string num2;
        private string sum;
        public string Num1
        {
            get { return num1; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num1 = value;
                onPropertyChanged("Num1");
            }
        }
        public string Num2
        {
            get { return num2; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num2 = value;
                onPropertyChanged("Num2");
            }
        }
        public string Sum
        {
            get
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                return res.ToString();
            }
            set
            {
                int res = int.Parse(Num1) + int.Parse(Num2);
                sum = res.ToString();
                onPropertyChanged("Result");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}