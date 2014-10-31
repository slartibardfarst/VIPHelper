using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private HttpClient _httpClient;
        private FavouriteVips _favouriteVipsForm;

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

            string defaultRegex = ConfigurationManager.AppSettings["DefaultRegex"];
            textBoxRegex.Text = string.IsNullOrEmpty(defaultRegex) ? "" : defaultRegex;

            _favouriteVipsForm = new FavouriteVips();
        }




        private async void buttonRefreshServers_Click(object sender, EventArgs e)
        {
            try
            {
                this.listViewVipServers.Items.Clear();

                var url = BuildBaseUrl();
                url += "/virtualserver";
                url += "/" + comboBoxVipServiceNames.Text;

                string response = await _httpClient.GetStringAsync(url);
                dynamic vipInfo = JObject.Parse(response);

                this.textBoxVipIp.Text = vipInfo.ipv46.Value;
                textBoxVipIp.Update();

                url += "/bindings";
                response = await _httpClient.GetStringAsync(url);
                var vipBindings = JArray.Parse(response);
                foreach (var binding in vipBindings)
                {
                    var bindingObj = binding.ToObject<dynamic>();
                    AddVipService(bindingObj.servicename.Value, bindingObj.curstate.Value, bindingObj.ipv46.Value, bindingObj.port.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string BuildBaseUrl()
        {
            string url = ConfigurationManager.AppSettings["VipInfoService"];
            url += this.radioButtonPROD.Checked ? "/prod" : "/qa";
            return url;
        }

        private void AddVipService(string svcName, string svcState, string ip, long port)
        {
            ListViewItem lvi = new ListViewItem("");
            if (!string.IsNullOrEmpty(textBoxRegex.Text) && Regex.IsMatch(svcName, textBoxRegex.Text))
                lvi.BackColor = System.Drawing.Color.LightSkyBlue;
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, svcName));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, svcState));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, ip));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, port.ToString()));
            listViewVipServers.Items.Add(lvi);
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            HandleEnableOrDisable("enable");
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            HandleEnableOrDisable("disable");
        }

        private async void HandleEnableOrDisable(string cmd)
        {
            var selectedServers = new List<string>();
            foreach (ListViewItem item in listViewVipServers.Items)
                if (item.Checked)
                    selectedServers.Add(item.SubItems[1].Text);

            var proceed = MessageBox.Show(this, string.Format("Are you sure you want to {0} the {1} selected servers?", cmd, selectedServers.Count), "Vip Helper", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            foreach (var server in selectedServers)
                EnableDisableServerInVip(server, cmd);

            await Task.Delay(500);
            buttonRefreshServers_Click(null, null);
        }


        private async void EnableDisableServerInVip(string server, string cmd)
        {
            string token = await GetCommandToken();

            string urlBase = BuildBaseUrl();
            string url = string.Format("{0}/service/{1}/{2}?apitoken={3}", urlBase, server, cmd, token);

            var response = await _httpClient.GetStringAsync(url);
            //var vipBindings = JArray.Parse(response);
        }

        private async Task<string> GetCommandToken()
        {
            string urlBase = BuildBaseUrl();
            string url = string.Format("{0}/token?user=api&password=Toptop10", urlBase);

            var response = await _httpClient.GetStringAsync(url);
            dynamic responseObj = JObject.Parse(response);
            string token = responseObj.ApiToken.Value;
            return token;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var url = BuildBaseUrl();
            url += "/virtualserver";

            string response = await _httpClient.GetStringAsync(url);
            var items = JArray.Parse(response);

            var namesList = items.Select(item => (dynamic)item.ToObject<dynamic>().name.Value).Cast<string>().ToList();
            namesList.Sort();
            foreach (var name in namesList)
                comboBoxVipServiceNames.Items.Add(name);

            string defaultVipName = ConfigurationManager.AppSettings["DefaultVipName"];
            if (!string.IsNullOrEmpty(defaultVipName))
                comboBoxVipServiceNames.Text = defaultVipName;
            else if (comboBoxVipServiceNames.Items.Count > 0)
                this.comboBoxVipServiceNames.Text = comboBoxVipServiceNames.Items[0] as string;

            comboBoxVipServiceNames.Update();
        }

        private void myFavouriteVIPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var favs = new FavouriteVips();
            favs.ShowDialog();
        }

        private void favouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var favs = new FavouriteVips();
            favs.ShowDialog();
        }
    }
}
