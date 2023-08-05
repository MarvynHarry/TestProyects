using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Soliution
    {

        public String GetmaxSrtring(string s)
        {
            if (string.IsNullOrEmpty(s))    
                return string.Empty;
                        
            int Max = 0;
            foreach (char item in s)
            {
                if (int.TryParse(item.ToString(), out int x))
                {
                    if(x > Max) Max = x;
                }
            }

            return Max.ToString();
        }

        public int CalPoints(string[] obj)
        {
            List<int> record = new();
            for (int i = 0; i < obj.Length; i++)
            {
                if (int.TryParse(obj[i], out int x))
                {
                    record.Add(x);
                    continue;
                }
                switch (obj[i])
                {
                    case "C":
                        record.Remove(record.Last());
                        break;
                    case "D":
                        record.Add(record.Last() * 2);
                        break;
                    case "+":
                        var last = record.Last();
                        var Plast = record[record.IndexOf(last) - 1];
                        record.Add(last + Plast);
                        break;
                    default:
                        break;
                }
            }

            return record.Sum();
        }
    }
}
