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

        public Car(string model, string registrationNo, int doors, Color carColor)
        {
            _model = model;
            _registrationNo = registrationNo;
            _doors = doors;
            _carColor = carColor;
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
            set { _doors = value; }
        }

        public Color CarColor
        {
            get { return _carColor; }
            set { _carColor = value; }
        }
    }
}
