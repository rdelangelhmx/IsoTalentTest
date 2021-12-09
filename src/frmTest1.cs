using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestIsoTalent
{
    public partial class frmTest1 : Form
    {
        public frmTest1()
        {
            InitializeComponent();
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            var counter = txtSentence.Text.ToArray()
                .GroupBy(letter => new { letter })
                .Select(s => new CntLetters { letter = s.Key.letter.ToString(), cnt = s.Count() })
                .ToList()
                .Where(w => w.letter == w.letter.ToLower())
                .OrderByDescending(o => o.cnt)
                .FirstOrDefault();
            if (counter != null)
                txtResult.Text = "Letter: " + counter.letter + " Count: " + counter.cnt;
            else
                txtResult.Text = "Letter: Count:";
        }
    }

    public class CntLetters
    {
        public string letter { get; set; }
        public int cnt { get; set; }
    }
}
