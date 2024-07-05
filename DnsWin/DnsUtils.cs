using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace switchDns
{
    public class DnsUtils
    {
        public static List<string> GetInterface()
        {
            List<string> l = new List<string>();
            foreach (NetworkInterface netInterface in   NetworkInterface.GetAllNetworkInterfaces())
            {
              
                string s =  netInterface.Name;
               

                l.Add(s);
            }
            return l;
        }

        public static List<string> GetDNSs(string InterfaceName)
        {
            List<string> l = new List<string>();
            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.Name == InterfaceName)
                {
                    IPInterfaceProperties ipProps = netInterface.GetIPProperties();

                    foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
                    {
                        string dns = addr.Address.ToString();
                        if (dns.IndexOf(".") > 0)
                        {
                            l.Add( dns);
                        }
                    }
                }
            }
            return l;

        }
    }
}
