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
        public string VipName { get; set; }
        public string VipComments { get; set; }
        public bool EditedByUser { get; set; }

        public AddEditVip()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (EditedByUser)
            {
                VipName = textBox_VipName.Text;
                VipComments = textBox_VipComments.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox_VipName_TextChanged(object sender, EventArgs e)
        {
            EditedByUser = true;
        }

        private void textBox_VipComments_TextChanged(object sender, EventArgs e)
        {
            EditedByUser = true;
        }

        private void AddEditVip_Shown(object sender, EventArgs e)
        {
            EditedByUser = false;
            textBox_VipName.Text = VipName;
            textBox_VipComments.Text = VipComments;
        }
    }
}
