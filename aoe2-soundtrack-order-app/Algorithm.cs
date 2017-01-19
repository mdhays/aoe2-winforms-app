using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoe2_soundtrack_order_app
{
    public static class Algorithm
    {
        static Random _random = new Random();

        public static List<string> Shuffle<T>(T[] refarray)
        {
            //List<string> trackNames = new List<string>();
            T[] array = new T[refarray.Length];
            refarray.CopyTo(array, 0);
            int n = array.Length;
            List<string> trackNames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                // ... It is equivalent to Math.random() in Java.
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;

                trackNames.Add(array[i].ToString());
            }

            return trackNames;
        }

















        //static List<string> Shuffle<T>(this Random rng, T[] array)
        //{
        //    List<string> trackNames = new List<string>();
        //    int n = array.Length;

        //    //while (n > 1)
        //    //{
        //    //    int k = rng.Next(n--);
        //    //    T temp = array[n];
        //    //    array[n] = array[k];
        //    //    array[k] = temp;
        //    //    // Add each random value to an array of strings and return that array.
        //    //    trackNames.Add(temp.ToString());
        //    }

        //    return trackNames;
        //}
    }

}
