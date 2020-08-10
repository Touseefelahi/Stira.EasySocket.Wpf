using Prism.Mvvm;
using Stira.Socket.Interfaces;
using Stira.Socket.Models;
using Stira.Socket.ViewModels;

namespace Stira.EasySocket.Sample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            SocketControl = new ControlViewModel
            {
                IsHex = true,
                DeveloperCommand = "010203"
            };
            ITcpClient tcpClient = new EasyTcpClient
            {
                Ip = "192.168.10.227",
                Port = 4040
            };
            var endBytesIdentifier = new byte[] { 0x0a, 0x0b };
            tcpClient.Connect(endBytesIdentifier);
            SocketControl.TcpClient.Connect("192.168.10.227", 4040, new byte[] { 0xa, 0xb });
            SocketControl.TcpClient.DataEvent += DataIncoming;
        }

        public IControlViewModel SocketControl { get; set; }

        private async void DataIncoming(object sender, IReplyPacket e)
        {
            var sent = await SocketControl.TcpClient.SendAsync(e.Reply.ToArray()).ConfigureAwait(false);
        }
    }
}