using System;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            ReportPrintTool printTool = new ReportPrintTool(new XtraReport1());
            printTool.PreviewForm.VisibleChanged += new EventHandler(PreviewFormEx_VisibleChanged);
            printTool.ShowPreviewDialog(); 
        }

        void PreviewFormEx_VisibleChanged(object sender, EventArgs e) {
            ((PrintPreviewFormEx)sender).PrintBarManager.AllowQuickCustomization = false;
            ((PrintPreviewFormEx)sender).PrintBarManager.Bars[2].OptionsBar.DrawDragBorder = false;
            ((PrintPreviewFormEx)sender).PrintBarManager.Bars[0].OptionsBar.DrawDragBorder = false;
        }
    }
}