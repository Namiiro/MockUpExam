using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MockUpExam
{
    public class Owner
    {
        private string _name;
        private string _address;
        private string _phone;


        public Owner(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public string Name
        {
            get { return _name; }

            set
            {
                if (value.Length < 4)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("The name must be at least 4 characters");
                }
            }
        }

        public string Address

        {
            get { return _address; }

            set
            {
                if (value.Length >= 6)
                {
                    _address = value;
                }
                else
                {
                    throw new ArgumentException("The address must be at least 6 characters");
                }
            }
        }

        public string Phone
        {
            get { return _phone; }

            set
            {
                if (value.Length == 8)
                {
                    _phone = value;
                }
                else
                {
                    throw new ArgumentException("The phone number must be exactly 8 characters. Please try again");
                }
            }
        }
    }
}
