using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockUpExam
{
    public enum Color 
    {
    Black, White, Gray, Red, Green, Blue
    }
    public class Car
    {
        
        private string _model;
        private string _registrationNo;
        private int _doors;
        private Color _carColor;
        private Owner _owner;

        public Car(string model, string registrationNo, int doors, Color carColor, Owner owner)
        {
            Model = model;
            
            RegistrationNo = registrationNo;

            Doors = doors;

            CarColor = carColor;

            Owner = owner;
        }

        public string Model
        {
            get { return _model; }

            set
            {
                if (value != null)
                {
                    _model = value;
                }
                else
                {
                    throw new ArgumentException("The model must not be null. Please specify a car model");
                }
            }
        }

        public string RegistrationNo
        {
            get { return _registrationNo; }
            set
            {
                if (value.Length == 7)
                {
                    _registrationNo = value;
                }
                else
                {
                    throw new ArgumentException("The registration no must be exactly 7 characters");
                }
            }
        }

        public int Doors
        {
            get { return _doors; }

            set
            {
                if (value >= 2 && value <= 5)
                {
                    _doors = value;
                }
                else
                {
                    throw new ArgumentException("The number of doors must be either 2 or 5 or in between");
                }
            }
        }

        public Color CarColor
        {
            get { return _carColor; }
            set { _carColor = value; }
        }

        public Owner Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
    }
}
