using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Qexal.CTI;

public static class Helpers
{
    /// <summary>
    /// Finds the MAC address of the first operation NIC found.
    /// </summary>
    /// <returns>The MAC address.</returns>
    public static string GetMacAddress()
    {
        var macAddresses = string.Empty;

        foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (nic.OperationalStatus != OperationalStatus.Up) continue;
            macAddresses += nic.GetPhysicalAddress().ToString();
            break;
        }

        return macAddresses;
    }

    public static string GetWindowsVersion()
    {
        RtlGetVersion(out var version);
        return $"Windows {version.MajorVersion}.{version.MinorVersion}.{version.BuildNumber}";
    }
        
        
    [DllImport("ntdll.dll", SetLastError = true)]
    private static extern uint RtlGetVersion(out OsVersionInfo versionInformation); // return type should be the NtStatus enum

    [StructLayout(LayoutKind.Sequential)]
    private struct OsVersionInfo
    {
        private readonly uint OsVersionInfoSize;
        internal readonly uint MajorVersion;
        internal readonly uint MinorVersion;
        internal readonly uint BuildNumber;
        private readonly uint PlatformId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        private readonly string CSDVersion;
    }
}