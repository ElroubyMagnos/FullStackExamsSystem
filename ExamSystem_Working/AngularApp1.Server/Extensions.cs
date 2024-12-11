using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElgazeraExams.Server
{
    public static class Extensions
    {
        public static List<T> Shuffle<T>(this List<T> list)  
        {  
            var rng = new Random();
            
            int n = list.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                T value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
            } 

            return list; 
        }
    }
}