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
    public partial class CreateProfileForm : Form
    {
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void CreateProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            EncryptionForm ec = new EncryptionForm();
            MessageBox.Show(ec.encryptString(
                "Phasellusidposuerejusto,egettempuslibero.Pellentesquefringillarisusapretiumultricies." +
                "Pellentesquevitaenislfelis.Vivamusfaucibusdictumfermentum.Namefficiturpellentesquefinibus." +
                "Nullamdiammauris,blanditatfeugiatsitamet,facilisisneclectus.Donecrhoncusmaximusleo,vel" +
                "variusaugueelementumvitae.Integerullamcorpercondimentumaccumsan.Aeneannisifelis,egestasnec" +
                "nequenec,fermentumdictumlibero.Fuscepretiumrisusetdolorcondimentumgravidaefficitureufelis." +
                "Suspendisseconvallisgravidamassa,etfermentumenimfaucibusbibendum.Praesentaccumsanfelismauris," +
                "egetfermentumurnamollisvitae.Nullamolestieenimvellacusullamcorper,acursusmaurisposuere.In" +
                "egestasfaucibuserosatsagittis.Maecenasutquamvelarcupretiumporttitoridiaculisnisl."));
        }

        public int getIntValueFromInfo()
        {
            string str1 = firstNameTextBox.Text;
            string str2 = lastNameTextBox.Text;
            string str3 = emailTextBox.Text;
            string str4 = usernameTextBox.Text;

            Random rand = new Random(Environment.TickCount);
            int total = 0;
            var concat = (str1 + str2 + str3 + str4).ToCharArray();

            EncryptionForm ec = new EncryptionForm();

            for (int i = 0; i < concat.Length; i++)
            {
                total += Convert.ToInt16(concat[i]);
            }

            total += rand.Next();

            return total;
        }
    }
}
