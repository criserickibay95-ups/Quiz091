using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounts;


namespace Quiz091
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double diameter = getCircleDiameter(radius);

            lblResult.Text = "Diameter: " + diameter.ToString();

        }
        public double getCircleDiameter(double radius)
        {
            return radius * 2;
        }

        public struct Product
        {
            public string code;
            public string description;
            public string price;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product();

            p.code = txtCode.Text;
            p.description = txtDescription.Text;
            p.price = txtPrice.Text;

            lblProduct.Text = "Code: " + p.code + "\nDescription: " + p.description + "\nPrice: " + p.price;
        }

        private void btnFullName_Click(object sender, EventArgs e)
        {
            lblName.Text = "Full Name: " + new Person().full_name;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.account_number = txtAcctNumber.Text;

            lblAccount.Text = "Account Number: " + a.account_number; 

        }
    }
    }

