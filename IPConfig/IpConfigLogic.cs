using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace IPConfig
{
    internal class IpConfigLogic
    {

        public static List<NetworkInterface> NetworkInterfaces { get; set; }

        static IpConfigLogic()
        {
            RefreshNetworkInterfaces();
        }

        public static void RefreshNetworkInterfaces()
        {
            NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces().ToList();
        }

        public List<string> ShowNetworkInterfaces()
        {
            var adapterText =
                (
                    NetworkInterfaces.Where(nic => nic.OperationalStatus == OperationalStatus.Up).Select(
                        nic => nic.Description)
                );
            return adapterText.ToList();
        }

        public string GetLocalIP(string criteria)
        {
            var localip =
                (
                    NetworkInterfaces.Where(nic => nic.Description == criteria).Select(nic => nic.GetIPProperties())
                );

            if (localip.Any())
            {
                var firstIp = localip.First();
                if (firstIp.UnicastAddresses.Any())
                {
                    try
                    {
                        return firstIp.UnicastAddresses.Last().Address.ToString();
                    }
                    catch (NullReferenceException) { }
                }
            }
            return "0.0.0.0";
        }

        public string GetAdapterAddress(string criteria)
        {
            var adapteraddress =
                (
                    NetworkInterfaces.Where(nic => nic.Description == criteria).Select(
                        nic => BitConverter.ToString(nic.GetPhysicalAddress().GetAddressBytes()))
                ).First();
            return adapteraddress;
        }

        public string GetSubnetMask(string criteria)
        {
            var subnet =
                (
                    NetworkInterfaces.Where(nic => nic.Description == criteria).Select(nic => nic.GetIPProperties())
                );
            if (subnet.Any())
            {
                var firstSubnet = subnet.First();
                if (firstSubnet.UnicastAddresses.Any())
                {
                    try
                    {
                        return firstSubnet.UnicastAddresses.Last().IPv4Mask.ToString();
                    }
                    catch (NullReferenceException){}
                }
            }
            return "0.0.0.0";
        }

        public string GetDefaultGateway(string criteria)
        {
            var gatewayip =
                (
                    NetworkInterfaces.Where(nic => nic.Description == criteria).Select(nic => nic.GetIPProperties())
                );
            if (gatewayip.Any())
            {
                var defaultgateway = gatewayip.First();
                if (defaultgateway.GatewayAddresses.Any())
                {
                    try
                    {
                        return defaultgateway.GatewayAddresses.Last().Address.ToString();
                    }
                    catch (NullReferenceException){}
                }
            }
            return "0.0.0.0";
        }


        public void ReleaseIP(string criteria)
        {
            var name = (NetworkInterfaces.Where(nic => nic.Description == criteria).Select(nic => nic.Name)
                       ).ToString();
            Process.Start(Environment.SystemDirectory + "\\IPConfig.exe", "/release " + name + "*");
        }

        public void RenewIP(string criteria)
        {
            var name =
                (NetworkInterfaces.Where(nic => nic.Description == criteria).Select(nic => nic.Name)
                ).ToString();
            Process.Start(Environment.SystemDirectory + "\\IPConfig.exe", "/renew " + name + "*");
        }

        public void ReleaseAll()
        {
            Process.Start(Environment.SystemDirectory + "\\IPConfig.exe", "/release");
        }

        public void RenewAll()
        {
            Process.Start(Environment.SystemDirectory + "\\IPConfig.exe", "/renew");
        }
    }
}
