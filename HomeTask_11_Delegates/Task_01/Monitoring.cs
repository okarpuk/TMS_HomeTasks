using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11_Delegates.Task_01
{
    public class Monitoring
    {
        public delegate void PriceShowing(int myPrice);
        public static PriceShowing? priceShowing;
        private static int calculatedPrice;
        private static int generatedPricesQTY = 5;

        public Monitoring(PriceShowing priceToDisplay)
        {
            priceShowing += priceToDisplay;
            PriceToGet();
        }

        public static void PriceDisplay() => priceShowing(calculatedPrice);

        private static void PriceToGet() => calculatedPrice = (int)new RandomPrice().CreatePrice(generatedPricesQTY).Average();
    }
}
