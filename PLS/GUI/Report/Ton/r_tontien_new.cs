using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BUS;
using ControlLocalizer;

namespace GUI
{
    public partial class r_tontien_new : DevExpress.XtraReports.UI.XtraReport
    {
        public r_tontien_new()
        {
            InitializeComponent();
            txttime.Text = Biencucbo.time;
        }
    }
}
