using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            this.Values = new List<T>();
        }
        public List<T> Values { get; set; }

        public int GreaterValuesThan(T targetItem)
        {
            int counter = 0;
            foreach (var value in this.Values)
            {
                if (value.CompareTo(targetItem) > 0)
                {
                    counter++;
                }

            }
            return counter;
        }

        public void Swap(int a, int b)
        {
            if (a >= 0 && a < this.Values.Count && b >= 0 && b < this.Values.Count)
            {
                T tempValue = this.Values[a];
                this.Values[a] = this.Values[b];
                this.Values[b] = tempValue;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            string result = sb.ToString().TrimEnd();
            return result;
        }
    }
}
