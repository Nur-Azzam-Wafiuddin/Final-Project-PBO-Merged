using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartTemp
{
    public static class Cart
    {
        private static List<string> TempCart = new List<string>();
        private static int CartCount;
        public static void setCount()
        {
            CartCount = 0;
        }
        public static int getCount()
        {
            return CartCount;
        }
        public static void add(string name)
        {
            TempCart.Add(name);
            CartCount++;
        }
        public static void remove(int i)
        {
            TempCart.RemoveAt(i);
            CartCount--;
            for (int j = i + 1; j < CartCount; j++)
            {
                if (TempCart[j + 1] != null)
                {
                    TempCart.Insert(j, TempCart[j + 1]);
                    TempCart.RemoveAt(j + 1);
                }
            }
        }
        public static string show(int i)
        {
            return TempCart[i];
        }
        public static int len()
        {
            return TempCart.Count;
        }
        public static void clear()
        {
            CartCount = 0;
            TempCart.Clear();
        }

    }
}
