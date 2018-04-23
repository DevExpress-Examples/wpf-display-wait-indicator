Imports DevExpress.Xpf.Grid

Imports System
Imports System.Windows

Namespace dxSampleGrid
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            vm = New MyViewModel()
            DataContext = vm
        End Sub
        Private vm As MyViewModel

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vm.IsWaitIndicatorVisible = Not vm.IsWaitIndicatorVisible
        End Sub

        Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vm.WaitIndicatorText = "Initializing... " & Date.Now.Millisecond
        End Sub
    End Class

End Namespace
