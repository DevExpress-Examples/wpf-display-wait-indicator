using DevExpress.Xpf.Grid;

using System;
using System.Windows;

namespace dxSampleGrid {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            vm = new MyViewModel();
            DataContext = vm;
        }
        MyViewModel vm;

        private void Button_Click(object sender, RoutedEventArgs e) {
            vm.IsWaitIndicatorVisible = !vm.IsWaitIndicatorVisible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            vm.WaitIndicatorText = "Initializing... " + DateTime.Now.Millisecond;
        }
    }
}
