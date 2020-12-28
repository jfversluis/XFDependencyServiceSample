using System;
using XFDependencyServiceSample.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfoService))]
namespace XFDependencyServiceSample.Droid
{
    public class DeviceInfoService : IDeviceInfoService
    {
        public string GetDeviceModel()
        {
            return Android.OS.Build.Model;
        }
    }
}
