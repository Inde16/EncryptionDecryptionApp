using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityPissaris
{
    public partial class frmMD5 : Form
    {
        public frmMD5()
        {
            InitializeComponent();
        }

        static string GetMd5Hash(MD5 md5Hash, String input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            txtHash.Text = GetMd5Hash(md5Hash, txtPass.Text);
        }
    }
}
