using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Ayan_Shukla_NEA
{
    public static class hash
    {
        

        public static string Compute(string input)
        {
            unchecked
            {
                const uint FNV_OFFSET = 2166136261u;//Number to begin hash with
                const uint FNV_PRIME = 16777619u;//Number we multiply with
                uint hash = FNV_OFFSET;//Start hash with first number

                foreach (byte b in System.Text.Encoding.UTF8.GetBytes(input ?? ""))//Turn each input into bytes, if input is empty turn it into " "
                {
                    hash ^= b;//combines hash with bytes
                    hash *= FNV_PRIME;//mixes the hash more
                }

                return hash.ToString("x8");//convert 32bit value into hex
            }
        }
    }
}
