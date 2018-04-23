using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XtraReport1 r = new XtraReport1();
            r.PrintingSystem.PreviewFormEx.VisibleChanged += new EventHandler(PreviewFormEx_VisibleChanged);
            r.ShowPreviewDialog();

        }

        void PreviewFormEx_VisibleChanged(object sender, EventArgs e)
        {
            ((DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)sender).PrintBarManager.AllowQuickCustomization = false;
            ((DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)sender).PrintBarManager.Bars[2].OptionsBar.DrawDragBorder = false;
            ((DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)sender).PrintBarManager.Bars[0].OptionsBar.DrawDragBorder = false;
        }
    }
}