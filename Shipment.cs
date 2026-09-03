using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP1
{
    internal struct Shipment
    {
        #region Fields
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        #endregion
        #region Properties
        public string TrackingCode { get { return trackingCode; } }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
         public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                deliveryFee = value;
            }
        }
        public DeliveryAddress Destination { get; set; }
        public decimal EstimatedCost =>DeliveryFee+(Weight*5);
        #endregion
    }
}
