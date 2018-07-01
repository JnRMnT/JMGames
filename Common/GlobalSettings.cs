using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JMGames.Common
{
    public class GlobalSettings
    {
        public static int Seed = 0;
        public delegate string ResourceProvider(string resourceKey);
        public static ResourceProvider GetResourceValue;
        public static string GetResource(string resourceKey, string defaultValue)
        {
            if (GetResourceValue != null)
            {
                return GetResourceValue(resourceKey);
            }
            else
            {
                return defaultValue;
            }
        }

        private static Random randomGenerator;
        public static Random RandomGenerator
        {
            get
            {
                if(randomGenerator == null)
                {
                    randomGenerator = new Random();
                    if (Seed != default(int))
                    {
                        randomGenerator = new Random(GlobalSettings.Seed);
                    }
                }
                return randomGenerator;
            }
        }
    }
}
