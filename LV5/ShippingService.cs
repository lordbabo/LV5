using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class ShippingService  // ZADATAK 2
    {
        private double priceOfMassUnit;
        public ShippingService(double priceOfMassUnit)
        {
            this.priceOfMassUnit = priceOfMassUnit;
        }
        public double ShippingPrice(Box item)
        {
            double shippingPrice = 0;
            shippingPrice = item.Weight * priceOfMassUnit;
            return shippingPrice;
        }
    }
}
