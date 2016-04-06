using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        // Declare subject & observers
        FireAlarmSubject subject;
        InstructionObserver obI;

        // Declare enum
        EFireCategory currFC;

        public Form1()
        {
            InitializeComponent();

            // Instantiate them
            subject = new FireAlarmSubject();
            obI = new InstructionObserver(subject);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            if (rdoMinor.Checked)
            {
                currFC = EFireCategory.MINOR;
            }
            else if (rdoSerious.Checked)
            {
                currFC = EFireCategory.SERIOUS;
            }
            else if (rdoInferno.Checked)
            {
                currFC = EFireCategory.INFERNO;
            }
            else
            {
                MessageBox.Show("Please pick a category!");
            }

            subject.OnFireEvent(currFC);
        }
    }
}
