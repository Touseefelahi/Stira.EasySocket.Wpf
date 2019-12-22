using System;
using System.Windows;
using System.Windows.Controls;

namespace Stira.EasySocket.Views
{
    /// <summary>
    /// Interaction logic for Control
    /// </summary>
    public partial class Control : UserControl
    {
        // Using a DependencyProperty as the backing store for IsDeveloperControlVisible. This
        // enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsDeveloperControlVisibleProperty =
            DependencyProperty.Register("IsDeveloperControlVisible", typeof(bool), typeof(Control), new PropertyMetadata(true, OnDeveloperControlVisibilityChanged));

        public Control()
        {
            InitializeComponent();
            DataContext = new Socket.ViewModels.ControlViewModel();
        }

        public bool IsDeveloperControlVisible
        {
            get => (bool)GetValue(IsDeveloperControlVisibleProperty);
            set => SetValue(IsDeveloperControlVisibleProperty, value);
        }

        private static void OnDeveloperControlVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (Control)d;
            control.ValueChanged((bool)e.NewValue);
        }

        private void ValueChanged(bool newValue)
        {
            IsDeveloperControlVisible = newValue;
            if (IsDeveloperControlVisible)
            {
                devCommandHexCheckBox.Visibility = Visibility.Visible;
                devCommandTextblock.Visibility = Visibility.Visible;
                devCommandTextbox.Visibility = Visibility.Visible;
                devCommandTextbutton.Visibility = Visibility.Visible;
            }
            else
            {
                devCommandHexCheckBox.Visibility = Visibility.Collapsed;
                devCommandTextblock.Visibility = Visibility.Collapsed;
                devCommandTextbox.Visibility = Visibility.Collapsed;
                devCommandTextbutton.Visibility = Visibility.Collapsed;
            }
        }
    }
}