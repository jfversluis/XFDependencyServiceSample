using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFDependencyServiceSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var deviceInfoService = DependencyService.Get<IDeviceInfoService>();

            if (deviceInfoService != null)
            {
                DeviceModelLabel.Text = deviceInfoService.GetDeviceModel();
            }
        }
    }
}
