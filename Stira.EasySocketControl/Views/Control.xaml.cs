using Stira.Socket.Interfaces;
using System.Windows.Controls;

namespace Stira.EasySocket.Views
{
    /// <summary>
    /// Interaction logic for Control
    /// </summary>
    public partial class Control : UserControl
    {
        public Control()
        {
            InitializeComponent();
            DataContext = new Socket.ViewModels.ControlViewModel();
        }
    }
}