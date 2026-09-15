using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    public struct Shipment
    {
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;

        private DeliveryAddress _destination;
   
        public string GetTrackingCode()
        {
            return _trackingCode;
        }
    
        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                _description = description;
            }
        }

        public double GetWeight()
        {
            return _weight;
        }

        public void SetWeight(double weight)
        {
            if (weight > 0)
            {
                _weight = weight;
            }
        }

        public decimal GetDeliveryFee()
        {
            return _deliveryFee;
        }

        private void SetDeliveryFee(decimal deliveryFee)
        {
            if (deliveryFee > 0)
            {
                _deliveryFee = deliveryFee;
            }
        }

        public DeliveryAddress GetDestination()
        {
            return _destination;
        }

        public void SetDestination(DeliveryAddress destination)
        {
            _destination = destination;
        }
        public decimal GetEstimatedCost()
        {
            return _deliveryFee + ((decimal)_weight * 5);
        }

        public Shipment(string trackingCode)
        {
            _trackingCode = trackingCode;

            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;

            _destination =
                new DeliveryAddress("Unknown", "Unknown", 0);
        }
        public Shipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            _trackingCode =
                string.IsNullOrWhiteSpace(trackingCode)
                ? "Unknown"
                : trackingCode;

            _description =
                string.IsNullOrWhiteSpace(description)
                ? "Unknown"
                : description;

            _weight =
                weight > 0
                ? weight
                : 1;

            _deliveryFee =
                deliveryFee > 0
                ? deliveryFee
                : 50;

            _destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                SetDeliveryFee(newFee);
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {GetTrackingCode()}");
            Console.WriteLine($"Description: {GetDescription()}");
            Console.WriteLine($"Weight: {GetWeight()}");
            Console.WriteLine($"Delivery Fee: {GetDeliveryFee()}");
            Console.WriteLine($"Destination: {GetDestination().GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {GetEstimatedCost()}");
        }
}
}
