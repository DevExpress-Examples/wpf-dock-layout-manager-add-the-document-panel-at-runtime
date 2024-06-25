
# WPF Dock Layout Manager - Add the DocumentPanel at Runtime

You can use the `DockManager.GetItem` method to find the [DocumentGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentGroup) where you want to add a [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel). Use the [AddDocumentGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerBase.AddDocumentGroup(DevExpress.Xpf.Layout.Core.DockType)) method to add a new [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel) to this group. To activate this panel, call the [DockController.Activate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerBase.Activate.overloads) method.

<img src="https://user-images.githubusercontent.com/12169834/175319724-deb73350-0fa6-461b-ae5d-cc2a9d2df2c5.png" width=575px/>

<!-- default file list -->
## Files to Look At

* [Window1.xaml](./CS/SimpleDockingApplication/Window1.xaml) (VB: [Window1.xaml](./VB/SimpleDockingApplication/Window1.xaml))
* [Window1.xaml.cs](./CS/SimpleDockingApplication/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/SimpleDockingApplication/Window1.xaml.vb))
<!-- default file list end -->

## Documentation

- [Manage Dock Panels in Code](https://docs.devexpress.com/WPF/15540/controls-and-libraries/layout-management/dock-windows/miscellaneous/managing-dock-panels-in-code)
