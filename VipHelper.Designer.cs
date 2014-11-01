using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class VipHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshServers = new System.Windows.Forms.Button();
            this.listViewVipServers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioButtonQA = new System.Windows.Forms.RadioButton();
            this.radioButtonPROD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVipIp = new System.Windows.Forms.TextBox();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.comboBoxVipServiceNames = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIP Name:";
            // 
            // buttonRefreshServers
            // 
            this.buttonRefreshServers.Location = new System.Drawing.Point(108, 165);
            this.buttonRefreshServers.Name = "buttonRefreshServers";
            this.buttonRefreshServers.Size = new System.Drawing.Size(185, 23);
            this.buttonRefreshServers.TabIndex = 3;
            this.buttonRefreshServers.Text = "Refresh VIP Servers List";
            this.buttonRefreshServers.UseVisualStyleBackColor = true;
            this.buttonRefreshServers.Click += new System.EventHandler(this.buttonRefreshServers_Click);
            // 
            // listViewVipServers
            // 
            this.listViewVipServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewVipServers.CheckBoxes = true;
            this.listViewVipServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewVipServers.Location = new System.Drawing.Point(12, 240);
            this.listViewVipServers.Name = "listViewVipServers";
            this.listViewVipServers.Size = new System.Drawing.Size(381, 230);
            this.listViewVipServers.TabIndex = 6;
            this.listViewVipServers.UseCompatibleStateImageBehavior = false;
            this.listViewVipServers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "State";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IP";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Port";
            this.columnHeader5.Width = 42;
            // 
            // radioButtonQA
            // 
            this.radioButtonQA.AutoSize = true;
            this.radioButtonQA.Checked = true;
            this.radioButtonQA.Location = new System.Drawing.Point(87, 19);
            this.radioButtonQA.Name = "radioButtonQA";
            this.radioButtonQA.Size = new System.Drawing.Size(40, 17);
            this.radioButtonQA.TabIndex = 8;
            this.radioButtonQA.TabStop = true;
            this.radioButtonQA.Text = "QA";
            this.radioButtonQA.UseVisualStyleBackColor = true;
            // 
            // radioButtonPROD
            // 
            this.radioButtonPROD.AutoSize = true;
            this.radioButtonPROD.Location = new System.Drawing.Point(188, 19);
            this.radioButtonPROD.Name = "radioButtonPROD";
            this.radioButtonPROD.Size = new System.Drawing.Size(56, 17);
            this.radioButtonPROD.TabIndex = 8;
            this.radioButtonPROD.Text = "PROD";
            this.radioButtonPROD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQA);
            this.groupBox1.Controls.Add(this.radioButtonPROD);
            this.groupBox1.Location = new System.Drawing.Point(43, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 49);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Environment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "VIP IP:";
            // 
            // textBoxVipIp
            // 
            this.textBoxVipIp.Location = new System.Drawing.Point(59, 209);
            this.textBoxVipIp.Name = "textBoxVipIp";
            this.textBoxVipIp.ReadOnly = true;
            this.textBoxVipIp.Size = new System.Drawing.Size(250, 20);
            this.textBoxVipIp.TabIndex = 10;
            // 
            // buttonEnable
            // 
            this.buttonEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEnable.Location = new System.Drawing.Point(11, 481);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(109, 23);
            this.buttonEnable.TabIndex = 11;
            this.buttonEnable.Text = "Enable Selected";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDisable.Location = new System.Drawing.Point(126, 481);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(109, 23);
            this.buttonDisable.TabIndex = 12;
            this.buttonDisable.Text = "Disable Selected";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Regex:";
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(104, 123);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(256, 20);
            this.textBoxRegex.TabIndex = 7;
            // 
            // comboBoxVipServiceNames
            // 
            this.comboBoxVipServiceNames.FormattingEnabled = true;
            this.comboBoxVipServiceNames.Location = new System.Drawing.Point(104, 33);
            this.comboBoxVipServiceNames.Name = "comboBoxVipServiceNames";
            this.comboBoxVipServiceNames.Size = new System.Drawing.Size(256, 21);
            this.comboBoxVipServiceNames.TabIndex = 14;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(-3, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 10);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favouritesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            this.favouritesToolStripMenuItem.Click += new System.EventHandler(this.favouritesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxVipServiceNames);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.textBoxVipIp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.listViewVipServers);
            this.Controls.Add(this.buttonRefreshServers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VIP Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefreshServers;
        private List<Label> labels = new List<Label>();
        private List<CheckBox> checkboxes = new List<CheckBox>();
        private ListView listViewVipServers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private RadioButton radioButtonQA;
        private RadioButton radioButtonPROD;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBoxVipIp;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button buttonEnable;
        private Button buttonDisable;
        private Label label3;
        private TextBox textBoxRegex;
        private ComboBox comboBoxVipServiceNames;
        private ImageList imageList1;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem favouritesToolStripMenuItem;

    }
}

