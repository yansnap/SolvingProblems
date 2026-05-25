using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    internal class In32ToIpv4
    {
        public static string UInt32ToIP(uint ip)
        {
            StringBuilder sb = new StringBuilder();
            uint number = 0;
            number = (((ip / 256) / 256) / 256) % 256;
            sb.Append(number.ToString());
            number = ((ip / 256) / 256) % 256;
            sb.Append("." + number.ToString());
            number = (ip / 256) % 256;
            sb.Append("." + number.ToString());
            number = ip % 256;
            sb.Append("." + number.ToString());

            return sb.ToString();

            /* Another SOLUTIONS */
            /*
            uint octet1, octet2, octet3, octet4;
            octet1 = ip >> 24 & 255;
            octet2 = ip >> 16 & 255;
            octet3 = ip >> 8 & 255;
            octet4 = ip & 255;
            return $"{octet1}.{octet2}.{octet3}.{octet4}";
            */

            /* OTHERS SOLUTIONS */
            /*   public static string UInt32ToIP(uint ip)
                    => IPAddress.Parse(ip.ToString()).ToString();

                public static string UInt32ToIP(uint ip) 
                    => string.Join(".",(new int[] {24,16,8,0}).Select(e=> ip >> e & 255 ));
            */
        }
    }
}



