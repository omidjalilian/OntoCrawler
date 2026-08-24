using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LiteLib;
//...........................................................................................
namespace My_WebCrawler
{
    public partial class FrmSetting : Form
    {
        public int SelectedIndex = -1;
//...........................................................................................       
        public FrmSetting()
        {
            InitializeComponent();
        }
//...........................................................................................
        //Add New FileType to ListView
        private void buttonAddExt_Click(object sender, EventArgs e)
        {
            FileTypeForm form = new FileTypeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = this.listViewFileMatches.Items.Add(form.textBoxTypeDescription.Text);
                item.SubItems.Add(form.numericUpDownMinSize.Value.ToString());
                item.SubItems.Add(form.numericUpDownMaxSize.Value.ToString());
            }
        }
//...........................................................................................
        //Edit Existing FileType From ListView
        private void buttonEditExt_Click(object sender, EventArgs e)
        {
            if (this.listViewFileMatches.SelectedItems.Count == 0)
                return;
            ListViewItem item = this.listViewFileMatches.SelectedItems[0];
            FileTypeForm form = new FileTypeForm();
            form.textBoxTypeDescription.Text = item.Text;
            if (item.SubItems.Count <= 1)
                item.SubItems.Add("0");
            form.numericUpDownMinSize.Value = int.Parse(item.SubItems[1].Text);
            if (item.SubItems.Count <= 2)
                item.SubItems.Add("0");
            form.numericUpDownMaxSize.Value = int.Parse(item.SubItems[2].Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                item.Text = form.textBoxTypeDescription.Text;
                item.SubItems[1].Text = form.numericUpDownMinSize.Value.ToString();
                item.SubItems[2].Text = form.numericUpDownMaxSize.Value.ToString();
            }
        }
//...........................................................................................
        //Delete Existing FileType From ListView
        private void buttonDeleteExt_Click(object sender, EventArgs e)
        {
            if (this.listViewFileMatches.SelectedItems.Count == 0)
                return;
            ListViewItem item = this.listViewFileMatches.SelectedItems[0];
            item.Remove();
        }
//...........................................................................................
        //Save To XML File
        private void buttonSettingsOK_Click(object sender, EventArgs e)
        {
            Settings.SetValue(this);
        }
//...........................................................................................
        //Display Last Setting
        private void FrmSetting_Load(object sender, EventArgs e)
        {
            Settings.GetValue(this);
            if (SelectedIndex != -1)
                this.tabControlSettings.SelectedIndex = SelectedIndex;
        }
//...........................................................................................
    }
}