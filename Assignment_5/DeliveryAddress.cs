using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{

    public struct DeliveryAddress
    {
        private string _city;
        private string _street;
        private int _buildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            _city = city;
            _street = street;
            _buildingNumber = buildingNumber;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetCity(string city)
        {
            _city = city;
        }

        public string GetStreet()
        {
            return _street;
        }

        public void SetStreet(string street)
        {
            _street = street;
        }

        public int GetBuildingNumber()
        {
            return _buildingNumber;
        }

        public void SetBuildingNumber(int buildingNumber)
        {
            _buildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{_city}, {_street}, Building {_buildingNumber}";
        }
    }

}
