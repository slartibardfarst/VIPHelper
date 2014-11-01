using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class FavouriteVips : Form
    {
        public FavouriteVips()
        {
            InitializeComponent();
            this.buttonDeleteVIP.Enabled = false;
            this.buttonEditVIP.Enabled = false;

            var favs = ReadFavouriteVipsFromAppConfig();
            foreach (var fav in favs)
            {
                var lvi = new ListViewItem(new string[] {fav.Item1, fav.Item2});
                this.listView_FavouriteVips.Items.Add(lvi);
            }
        }

        private List<Tuple<string, string>> ReadFavouriteVipsFromAppConfig()
        {
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();

            var favVips = ConfigurationManager.GetSection("FavouriteVips") as NameValueCollection;
            if (favVips != null)
            {
                foreach (var key in favVips.AllKeys)
                {
                    result.Add(new Tuple<string, string>(key, favVips.GetValues(key).FirstOrDefault()));
                }
            }

            return result;
        }

        private void WriteFavouriteVipsToConfig(List<Tuple<string, string>> favs)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            XmlNode nodeFavVips = xmlDoc.SelectSingleNode("//FavouriteVips");
            nodeFavVips.RemoveAll();

            foreach (var fav in favs)
            {
                var favNode = xmlDoc.CreateElement("add");
                favNode.SetAttribute("key", fav.Item1);
                favNode.SetAttribute("value", fav.Item2);

                nodeFavVips.AppendChild(favNode);
            }

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("FavouriteVips");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddVIP_Click(object sender, EventArgs e)
        {
            var editVip = new AddEditVip();
            DialogResult res = editVip.ShowDialog();
        }

        private void buttonEditVIP_Click(object sender, EventArgs e)
        {
            var editVip = new AddEditVip();
            int i = listView_FavouriteVips.SelectedIndices[0];
            editVip.VipName = listView_FavouriteVips.Items[i].Text;
            editVip.VipComments = listView_FavouriteVips.Items[i].SubItems[1].Text;
            DialogResult res = editVip.ShowDialog();
        }

        private void buttonDeleteVIP_Click(object sender, EventArgs e)
        {

        }

        private void listView_FavouriteVips_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = listView_FavouriteVips.SelectedIndices;
            buttonDeleteVIP.Enabled = items.Count > 0;
            buttonEditVIP.Enabled = items.Count > 0;
        }
    }
}
