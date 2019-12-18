using Prism.Mvvm;
using Stira.Socket.Interfaces;
using Stira.Socket.ViewModels;

namespace Stira.EasySocket.Sample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Sample Stira Socket";

        public MainWindowViewModel()
        {
            SocketControl = new ControlViewModel
            {
                IsHex = true,
                DeveloperCommand = "010203"
            };
        }

        public IControlViewModel SocketControl { get; set; }
    }
}