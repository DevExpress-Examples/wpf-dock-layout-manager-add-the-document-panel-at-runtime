Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Docking

Namespace SimpleDockingApplication
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		Private counter As Integer = 2
		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim documentGroup As DocumentGroup = TryCast(dockManager1.GetItem("documentGroup"), DocumentGroup) ' searh a group
			If documentGroup Is Nothing Then
				documentGroup = dockManager1.DockController.AddDocumentGroup(DevExpress.Xpf.Layout.Core.DockType.Left) ' create the if necessary
				documentGroup.Name = "documentGroup"
			End If
			Dim docPanel As DocumentPanel = dockManager1.DockController.AddDocumentPanel(documentGroup) ' сreate a panel in the document group
			counter += 1
			docPanel.Caption = String.Format("Document {0}", counter)
			Me.dockManager1.DockController.Activate(docPanel)
		End Sub
	End Class
End Namespace
