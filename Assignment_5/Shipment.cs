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


        // TrackingCode - Getter only
        public string GetTrackingCode()
        {
            return _trackingCode;
        }


        // Description - Getter
        public string GetDescription()
        {
            return _description;
        }

        // Description - Setter
        public void SetDescription(string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                _description = description;
            }
        }


        // Weight - Getter
        public double GetWeight()
        {
            return _weight;
        }

        // Weight - Setter
        public void SetWeight(double weight)
        {
            if (weight > 0)
            {
                _weight = weight;
            }
        }


        // DeliveryFee - Getter
        public decimal GetDeliveryFee()
        {
            return _deliveryFee;
        }

        // DeliveryFee - Private Setter
        private void SetDeliveryFee(decimal deliveryFee)
        {
            if (deliveryFee > 0)
            {
                _deliveryFee = deliveryFee;
            }
        }


        // Destination - Getter
        public DeliveryAddress GetDestination()
        {
            return _destination;
        }

        // Destination - Setter
        public void SetDestination(DeliveryAddress destination)
        {
            _destination = destination;
        }


        // EstimatedCost - Getter
        public decimal GetEstimatedCost()
        {
            return _deliveryFee + ((decimal)_weight * 5);
        }


        // Constructor 1
        public Shipment(string trackingCode)
        {
            _trackingCode = trackingCode;

            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;

            _destination =
                new DeliveryAddress("Unknown", "Unknown", 0);
        }


        // Constructor 2
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


        // Update Delivery Fee
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                SetDeliveryFee(newFee);
            }
        }


        // Print Shipment
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
