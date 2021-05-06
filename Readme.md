<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/T442248dx/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/T442248dx/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/T442248dx/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/T442248dx/MainWindow.xaml.vb))
* [MyViewModel.cs](./CS/T442248dx/MyClasses/MyViewModel.cs) (VB: [MyViewModel.vb](./VB/T442248dx/MyClasses/MyViewModel.vb))


# How to use the WaitIndicator control

**IMPORTANT:** To show an indicator while the main thread is locked, use the following components instead of a standalone [WaitIndicator](https://docs.devexpress.com/WPF/114373/controls-and-libraries/windows-and-utility-controls/wait-indicator):
* [SplashScreenManager](https://docs.devexpress.com/WPF/401685/controls-and-libraries/windows-and-utility-controls/splash-screen-manager) (available in **v20.1** and newer) - shows an indicator window in a separate thread;
* [LoadingDecorator](https://github.com/DevExpress-Examples/how-to-add-wait-indicator-to-your-application-t604381) - automatically shows the splash screen when the content element is loaded;
* [DXSplashScreen](https://docs.devexpress.com/WPF/9949/controls-and-libraries/windows-and-utility-controls/dxsplashscreen) (obsolete; use in versions prior to **v20.1**) - shows an indicator window in a separate thread;

___

In this example, we used the `WaitIndicator` control and bound its `DeferedVisibility` property to `MyViewModel.IsWaitIndicatorVisible` to show/hide the indicator when `IsWaitIndicatorVisible` is changed.

```xml
<dx:WaitIndicator DeferedVisibility="{Binding IsWaitIndicatorVisible}" Content="{Binding WaitIndicatorText}">
    ...
</dx:WaitIndicator>
```


See also:
* [How to show a cancelablew wait indicator (Splash Screen) and update its content during a complex background operation](https://github.com/DevExpress-Examples/How-to-show-a-cancelable-Splash-Screen-and-update-its-content-during-a-complex-background-operation)
