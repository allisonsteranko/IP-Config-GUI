using System;
using System.Windows.Forms;

namespace IPConfig
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var logic = new IpConfigLogic();
            comboBox1.DataSource = logic.ShowNetworkInterfaces();
            PopulateForm();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateForm();
        }

        private void releaseButton_Click_1(object sender, EventArgs e)
        {
            var logic = new IpConfigLogic();
            logic.ReleaseIP(comboBox1.SelectedValue.ToString());
            PopulateForm();
        }

        private void renewButton_Click_1(object sender, EventArgs e)
        {
            var logic = new IpConfigLogic();
            logic.RenewIP(comboBox1.SelectedValue.ToString());
            PopulateForm();
        }

        private void PopulateForm()
        {
            var logic = new IpConfigLogic();
            adapterBox.Text = logic.GetAdapterAddress(comboBox1.SelectedValue.ToString());
            ipBox.Text = logic.GetLocalIP(comboBox1.SelectedValue.ToString());
            subnetBox.Text = logic.GetSubnetMask(comboBox1.SelectedValue.ToString());
            gatewayBox.Text = logic.GetDefaultGateway(comboBox1.SelectedValue.ToString());
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By: Justin Steranko", "About", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void ReleaseAllButton_Click(object sender, EventArgs e)
        {
            var logic = new IpConfigLogic();
            logic.ReleaseAll();
        }

        private void RenewAllButton_Click(object sender, EventArgs e)
        {
            var logic = new IpConfigLogic();
            logic.RenewAll();
        }

    }
}
