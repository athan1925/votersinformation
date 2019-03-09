using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotersInfomationSystem
{
    public partial class PrintSummary : UserControl
    {
        public PrintSummary()
        {
            InitializeComponent();
        }

        public static object printSummary1 { get; internal set; }
    }
}
