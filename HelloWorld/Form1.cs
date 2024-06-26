using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listCity.GetItemText(listCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string address = textAddress.Text;
            if (ValidateAddress(address))
            {
                labelError.Text = "Adres jest nieprawidlowy";
                labelError.ForeColor = System.Drawing.Color.Red;
            }

            MessageBox.Show(name + " " + address);
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                return true;
            }
            string pattern = @"^(?=.*[a-zA-Z])(?=.*\d).+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(address);
        }
    }
}
