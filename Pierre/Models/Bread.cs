using System;

namespace Pierre.Models
{
    public class Bread
    {
        public int NumberBread { get; private set; }

        public Bread(int loaves)
        {
            NumberBread = loaves;
        }

        public int GetPriceBread()
        {
            int pricePerLoaf = 5;
            int discountedPriceBread = 0;

            if (NumberBread > 0)
            {
                int discountedBread = NumberBread / 3;
                int remainingBread = NumberBread % 3;

                discountedPriceBread =
                    (discountedBread * 2 * pricePerLoaf) + (remainingBread * pricePerLoaf);
            }
            return discountedPriceBread;
        }
    }
}
