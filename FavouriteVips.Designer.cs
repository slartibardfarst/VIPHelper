namespace WindowsFormsApplication1
{
    partial class FavouriteVips
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "vip_sds_parsing_forservices_80",
            "Address Parser for PLC"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "vip_sds_parsing_forconsumers_80",
            "Address Parser for GeoWCF service"}, -1);
            this.listView_FavouriteVips = new System.Windows.Forms.ListView();
            this.vipNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VipDescColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddVIP = new System.Windows.Forms.Button();
            this.buttonEditVIP = new System.Windows.Forms.Button();
            this.buttonDeleteVIP = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_FavouriteVips
            // 
            this.listView_FavouriteVips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vipNameColumnHeader,
            this.VipDescColumnHeader});
            this.listView_FavouriteVips.FullRowSelect = true;
            this.listView_FavouriteVips.GridLines = true;
            this.listView_FavouriteVips.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView_FavouriteVips.Location = new System.Drawing.Point(12, 12);
            this.listView_FavouriteVips.MultiSelect = false;
            this.listView_FavouriteVips.Name = "listView_FavouriteVips";
            this.listView_FavouriteVips.Size = new System.Drawing.Size(546, 142);
            this.listView_FavouriteVips.TabIndex = 2;
            this.listView_FavouriteVips.UseCompatibleStateImageBehavior = false;
            this.listView_FavouriteVips.View = System.Windows.Forms.View.Details;
            this.listView_FavouriteVips.SelectedIndexChanged += new System.EventHandler(this.listView_FavouriteVips_SelectedIndexChanged);
            // 
            // vipNameColumnHeader
            // 
            this.vipNameColumnHeader.Text = "VIP Name";
            this.vipNameColumnHeader.Width = 224;
            // 
            // VipDescColumnHeader
            // 
            this.VipDescColumnHeader.Text = "Comments";
            this.VipDescColumnHeader.Width = 317;
            // 
            // buttonAddVIP
            // 
            this.buttonAddVIP.Location = new System.Drawing.Point(153, 170);
            this.buttonAddVIP.Name = "buttonAddVIP";
            this.buttonAddVIP.Size = new System.Drawing.Size(75, 23);
            this.buttonAddVIP.TabIndex = 3;
            this.buttonAddVIP.Text = "Add";
            this.buttonAddVIP.UseVisualStyleBackColor = true;
            this.buttonAddVIP.Click += new System.EventHandler(this.buttonAddVIP_Click);
            // 
            // buttonEditVIP
            // 
            this.buttonEditVIP.Location = new System.Drawing.Point(251, 170);
            this.buttonEditVIP.Name = "buttonEditVIP";
            this.buttonEditVIP.Size = new System.Drawing.Size(75, 23);
            this.buttonEditVIP.TabIndex = 3;
            this.buttonEditVIP.Text = "Edit";
            this.buttonEditVIP.UseVisualStyleBackColor = true;
            this.buttonEditVIP.Click += new System.EventHandler(this.buttonEditVIP_Click);
            // 
            // buttonDeleteVIP
            // 
            this.buttonDeleteVIP.Location = new System.Drawing.Point(349, 170);
            this.buttonDeleteVIP.Name = "buttonDeleteVIP";
            this.buttonDeleteVIP.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteVIP.TabIndex = 3;
            this.buttonDeleteVIP.Text = "Remove";
            this.buttonDeleteVIP.UseVisualStyleBackColor = true;
            this.buttonDeleteVIP.Click += new System.EventHandler(this.buttonDeleteVIP_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(504, 199);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(54, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FavouriteVips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 225);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDeleteVIP);
            this.Controls.Add(this.buttonEditVIP);
            this.Controls.Add(this.buttonAddVIP);
            this.Controls.Add(this.listView_FavouriteVips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FavouriteVips";
            this.Text = "Favourite VIPs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_FavouriteVips;
        private System.Windows.Forms.ColumnHeader vipNameColumnHeader;
        private System.Windows.Forms.ColumnHeader VipDescColumnHeader;
        private System.Windows.Forms.Button buttonAddVIP;
        private System.Windows.Forms.Button buttonEditVIP;
        private System.Windows.Forms.Button buttonDeleteVIP;
        private System.Windows.Forms.Button buttonOK;
    }
}