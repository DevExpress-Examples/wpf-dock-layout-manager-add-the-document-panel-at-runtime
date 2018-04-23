using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Docking;

namespace SimpleDockingApplication {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        private int counter = 2;
        private void button1_Click(object sender, RoutedEventArgs e) {
            DocumentGroup documentGroup = dockManager1.GetItem("documentGroup") as DocumentGroup; // searh a group
            if (documentGroup == null) {
                documentGroup = dockManager1.DockController.AddDocumentGroup(DevExpress.Xpf.Layout.Core.DockType.Left); // create the if necessary
                documentGroup.Name = "documentGroup";
            }
            DocumentPanel docPanel = dockManager1.DockController.AddDocumentPanel(documentGroup);  // сreate a panel in the document group
            docPanel.Caption = string.Format("Document {0}", ++counter);
            this.dockManager1.DockController.Activate(docPanel);
        }
    }
}
