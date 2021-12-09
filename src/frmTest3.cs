using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestIsoTalent
{
    public partial class frmTest3 : Form
    {
        public frmTest3()
        {
            InitializeComponent();

            //webBrowser1.ScriptErrorsSuppressed = true;
            var path = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/Test3.html", path));

        }
    }
}
