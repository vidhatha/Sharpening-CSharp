using System;

namespace Delegates_Lambdas_Events
{
    public class Shipping_Delegates
    {
        public delegate float ShippingDelegate(float price);

        public float zone1ShippingFee(float itemPrice)
        {
            return 0.25F * itemPrice;
        }

        public float zone2ShippingFee(float itemPrice)
        {
            return (0.12F * itemPrice) + 25;
        }

        public float zone3ShippingFee(float itemPrice)
        {
            return 0.08F * itemPrice;
        }

        public float zone4ShippingFee(float itemPrice)
        {
            return (0.04F * itemPrice) + 25;
        }

        public void CalculateShippingFees()
        {
            float shippingFee = 0.0F;
            string itemPrice;
            bool invalidZone = false;
            string destZone = null;
            ShippingDelegate shipFeePtr = null;

            Console.WriteLine("Enter destination zone");
            destZone = Console.ReadLine();
            while(destZone.ToLower() != "exit")
            {
                switch(destZone.ToLower())
                {
                    case "zone1":
                        shipFeePtr = zone1ShippingFee;
                        break;
                    case "zone2":
                        shipFeePtr = zone2ShippingFee;
                        break;
                    case "zone3":
                        shipFeePtr = zone3ShippingFee;
                        break;
                    case "zone4":
                        shipFeePtr = zone4ShippingFee;
                        break;
                    default:
                        invalidZone = true;
                        Console.WriteLine("Invalid Zone, please enter valid zone");
                        break;
                }

                if(!invalidZone)
                {
                    Console.WriteLine("Enter item Price");
                    itemPrice = Console.ReadLine();
                    shippingFee = shipFeePtr(float.Parse(itemPrice));
                    Console.WriteLine("The shipping fees are: " + shippingFee);
                }
                Console.WriteLine("Enter destination zone");
                destZone = Console.ReadLine();
            }
        }

    }
}
