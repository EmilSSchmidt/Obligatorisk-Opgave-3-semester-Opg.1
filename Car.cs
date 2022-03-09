using System;

namespace Obligatorisk_Opgave_3_semester
{
    public class Car
    {
        private int _id;
        private string _model;
        private int _price;
        private string _licenseplate;

        public Car(int id, string model, int price, string licenseplate)
        {
            Id = id;
            Model = model;
            Price = price;
            Licenseplate = licenseplate;

        }

        public Car()
        {

        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Model
        {
            get => _model;
            set 
            {
                if (value.Length >= 4)
                {
                    _model = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException( );
                }

            }

        }

        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _price = value;

            }
        }

        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value.Length >=2 && value.Length<=7)
                {
                    {
                        _licenseplate = value;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
