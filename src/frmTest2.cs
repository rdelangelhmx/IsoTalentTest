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
    public partial class frmTest2 : Form
    {
        public frmTest2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            lstCities.Items.Clear();
            string path = Path.GetDirectoryName("./");
            string line1 = null;
            string line2 = null;
            if (File.Exists(Path.Combine(path, "AllCities.txt")))
                File.Delete(Path.Combine(path, "AllCities.txt"));
            using (StreamReader cts1 = new StreamReader(Path.Combine(path, "CACities.txt")))
            {
                using (StreamReader cts2 = new StreamReader(Path.Combine(path, "USCities.txt")))
                {
                    using (StreamWriter ctsR = new StreamWriter(Path.Combine(path, "AllCities.txt")))
                    {
                        line1 = cts1.ReadLine();
                        line2 = cts2.ReadLine();
                        while (line1 != null && line2 != null)
                        {
                            if (String.CompareOrdinal(line1, line2) < 0)
                            {
                                lstCities.Items.Add(line1);
                                ctsR.WriteLine(line1);
                                line1 = cts1.ReadLine();
                            }
                            else
                            {
                                lstCities.Items.Add(line2);
                                ctsR.WriteLine(line2);
                                line2 = cts2.ReadLine();
                            }
                        }
                        while (line1 != null)
                        {
                            lstCities.Items.Add(line1);
                            ctsR.WriteLine(line1);
                            line1 = cts1.ReadLine();
                        }
                        while (line2 != null)
                        {
                            lstCities.Items.Add(line2);
                            ctsR.WriteLine(line2);
                            line2 = cts2.ReadLine();
                        }
                    }
                }
            }
            button1.Enabled = true;
        }
    }
}
