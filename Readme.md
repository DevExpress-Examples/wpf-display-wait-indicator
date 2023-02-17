<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128641746/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T604381)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Display the WPF WaitIndicator

This example shows the [WaitIndicator](https://docs.devexpress.com/WPF/114373/controls-and-libraries/windows-and-utility-controls/wait-indicator) control. The control's `DeferedVisibility` property is bound to the View Model's `IsWaitIndicatorVisible` property.

```xml
<dx:WaitIndicator DeferedVisibility="{Binding IsWaitIndicatorVisible}" Content="{Binding WaitIndicatorText}">
    <!-- ... -->
</dx:WaitIndicator>
```

The [WaitIndicator](https://docs.devexpress.com/WPF/114373/controls-and-libraries/windows-and-utility-controls/wait-indicator) works within the main application's UI thread. The UI freezes may affect the [WaitIndicator](https://docs.devexpress.com/WPF/114373/controls-and-libraries/windows-and-utility-controls/wait-indicator) animation.

To show an indicator while the main thread is locked, use the following components instead of a standalone [WaitIndicator](https://docs.devexpress.com/WPF/114373/controls-and-libraries/windows-and-utility-controls/wait-indicator):
* [SplashScreenManager](https://docs.devexpress.com/WPF/401685/controls-and-libraries/windows-and-utility-controls/splash-screen-manager) (available in **v20.1** and newer) - shows an indicator window in a separate thread;
* [LoadingDecorator](https://github.com/DevExpress-Examples/how-to-add-wait-indicator-to-your-application-t604381) - automatically shows the splash screen when the content element is loaded;
* [DXSplashScreen](https://docs.devexpress.com/WPF/9949/controls-and-libraries/windows-and-utility-controls/dxsplashscreen) (obsolete; use in versions prior to **v20.1**) - shows an indicator window in a separate thread;

<!-- default file list -->
## Files to Look At

* [MainWindow.xaml](./CS/T442248dx/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/T442248dx/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/T442248dx/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/T442248dx/MainWindow.xaml.vb))
* [MyViewModel.cs](./CS/T442248dx/MyClasses/MyViewModel.cs) (VB: [MyViewModel.vb](./VB/T442248dx/MyClasses/MyViewModel.vb))
<!-- default file list end -->

## Documentation

* [WaitIndicator](https://docs.devexpress.com/WPF/114373/controls-and-libraries/windows-and-utility-controls/wait-indicator)

## More Examples
* [Show a cancelable wait indicator (Splash Screen) and update its content during a complex background operation](https://github.com/DevExpress-Examples/How-to-show-a-cancelable-Splash-Screen-and-update-its-content-during-a-complex-background-operation)
