using System;
using XFDependencyServiceSample.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfoService))]
namespace XFDependencyServiceSample.iOS
{
    public class DeviceInfoService : IDeviceInfoService
    {
        public string GetDeviceModel()
        {
            return UIKit.UIDevice.CurrentDevice.Model;
        }
    }
}
