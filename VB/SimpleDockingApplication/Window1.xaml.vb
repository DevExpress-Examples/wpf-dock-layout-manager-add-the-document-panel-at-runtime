Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Docking

Namespace SimpleDockingApplication

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private counter As Integer = 2

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim documentGroup As DocumentGroup = TryCast(Me.dockManager1.GetItem("documentGroup"), DocumentGroup) ' searh a group
            If documentGroup Is Nothing Then
                documentGroup = Me.dockManager1.DockController.AddDocumentGroup(DevExpress.Xpf.Layout.Core.DockType.Left) ' create the if necessary
                documentGroup.Name = "documentGroup"
            End If

            Dim docPanel As DocumentPanel = Me.dockManager1.DockController.AddDocumentPanel(documentGroup) ' сreate a panel in the document group
            docPanel.Caption = String.Format("Document {0}", Threading.Interlocked.Increment(counter))
            Me.dockManager1.DockController.Activate(docPanel)
        End Sub
    End Class
End Namespace
