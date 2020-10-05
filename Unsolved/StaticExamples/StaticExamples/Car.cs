using System;

namespace StaticExamples
{
    /// <summary>
    /// A very simple representation of a car
    /// </summary>
    public class Car
    {
        #region Instance fields
        private string _licensePlate;
        private int _price;
        private static int _licenseCalls;
        private static int _priceCalls;

        #endregion

        #region Constructor
        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
        }
        #endregion

        #region Properties
        public string LicensePlate
        {
            get
            {
                _licenseCalls++;
                return _licensePlate;
            }

            set
            {
                _licenseCalls++;
                _licensePlate = value;
            }
        }

        public int Price
        {
            get
            {
                _priceCalls++;
                return _price;
            }
            set
            {
                _priceCalls++;
                _price = value;
            }
        }
        #endregion

        public static void PrintUsageStatistics()
        {
            Console.WriteLine($"The license property has been called {_licenseCalls} times");
            Console.WriteLine($"The price property has ben called {_priceCalls} times");
        }
    }

}