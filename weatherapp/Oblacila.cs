using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherapp
{
    public class Oblacila
    {
        public double Temperature;
        public bool IsRainy;
        public bool IsSunny;

        public Oblacila(double temperature, bool isRainy, bool isSunny)
        {
            Temperature = temperature;
            IsRainy = isRainy;
            IsSunny = isSunny;
        }

        public string GetClothingRecommendation()
        {
            if (IsRainy)
            {
                return "You should wear a waterproof jacket and carry an umbrella.";
            }
            else if (IsSunny)
            {
                if (Temperature > 20)
                {
                    return "You should wear light and breathable clothing, such as shorts and a t-shirt.";
                }
                else if (Temperature > 10)
                {
                    return "You should wear a little warmer clothes but nothing too much, it's still very warm.";
                }
                else
                {
                    return "You should wear warm clothes such as a thick sweater or jacket, long pants, and a scarf or hat to keep yourself adequately protected from the cold.";
                }
            }
            else
            {
                return "No specific clothing recommendations for the current weather.";
            }
        }
    }

}
