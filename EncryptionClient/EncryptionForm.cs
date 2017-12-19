using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionClient
{
    public partial class EncryptionForm : Form
    {
        public EncryptionForm()
        {
            InitializeComponent();
        }

        public void createProfileButton_Click(object sender, EventArgs e)
        {
            CreateProfileForm cp = new CreateProfileForm();
            cp.ShowDialog();
        }
    }
}
