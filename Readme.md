<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/SimpleDockingApplication/Window1.xaml) (VB: [Window1.xaml](./VB/SimpleDockingApplication/Window1.xaml))
* [Window1.xaml.cs](./CS/SimpleDockingApplication/Window1.xaml.cs) (VB: [Window1.xaml](./VB/SimpleDockingApplication/Window1.xaml))
<!-- default file list end -->
# How to add the DocumentPanel at runtime


<p>Find the necessary group by its name and use the DockManager.GetItem method. Add a new DocumentPanel to this group using the<br />
AddDocumentGroup method. To activate this panel, call the DockController.Activate method.</p>

<br/>


