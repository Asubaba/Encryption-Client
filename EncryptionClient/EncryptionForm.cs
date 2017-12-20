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

        private void encryptionButton_Click(object sender, EventArgs e)
        {

            encryptionTextField.Text = encryptString(encryptionTextField.Text);
        }

        private void decryptionButton_Click(object sender, EventArgs e)
        {
            encryptionTextField.Text = decryptString(encryptionTextField.Text);
        }

        public string encryptString(string str)
        {
            CreateProfileForm cp = new CreateProfileForm();
            int randVal = cp.getIntValueFromInfo();

            string input = str;
            char[] chars = input.ToArray();
            Random r = new Random(randVal);
            for (int i = 0; i < chars.Length; i++)
            {
                int randomIndex = r.Next(0, chars.Length);
                char temp = chars[randomIndex];
                chars[randomIndex] = chars[i];
                chars[i] = temp;
            }
            string scrambled = new string(chars);

            return scrambled;
        }

        public string decryptString(string str)
        {
            CreateProfileForm cp = new CreateProfileForm();
            int randVal = cp.getIntValueFromInfo();

            Random r = new Random(randVal);
            string scrambled = str;
            char[] scramChars = scrambled.ToArray();
            List<int> swaps = new List<int>();
            for (int i = 0; i < scramChars.Length; i++)
            {
                swaps.Add(r.Next(0, scramChars.Length));
            }
            for (int i = scramChars.Length - 1; i >= 0; i--)
            {
                char temp = scramChars[swaps[i]];
                scramChars[swaps[i]] = scramChars[i];
                scramChars[i] = temp;
            }

            string unscrambled = new string(scramChars);

            return unscrambled;
        }
    }
}
