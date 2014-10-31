using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class AddEditVip : Form
    {
        public string VipName
        {
            get { return this.textBox_VipName.Text; }
            set { this.textBox_VipName.Text = value; }
        }

        public string VipComments
        {
            get { return this.textBox_VipComments.Text; }
            set { this.textBox_VipComments.Text = value; }
        }

        public AddEditVip()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
