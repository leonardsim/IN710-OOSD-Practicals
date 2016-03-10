using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionTool
{
    public partial class Form1 : Form
    {
        //Call interface as type variable
        IEncryption encryptionMachine;

        public Form1()
        {
            InitializeComponent();
        }

        // Encrypts the user input
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // The classes that implement the interface IEncryption will be saved into the 
            // encryptionMachine depending on which radio button was checked
            if (rdoROT13.Checked)
            {
                encryptionMachine = new ROT13Encryptor();
            }
            else
            {
                encryptionMachine = new ReverseEncryptor();
            }

            // Whatever the user input in into the textbox will be saved, encrypted and then output inot the 2nd textbox
            string userInput = txtInput.Text;
            string encryptedMsg = encryptionMachine.Encrypt(userInput);
            txtOutput.Text = encryptedMsg;
        }

        // Decrypt functions the same as the encrypt for this case
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (rdoROT13.Checked)
            {
                encryptionMachine = new ROT13Encryptor();
            }
            else
            {
                encryptionMachine = new ReverseEncryptor();
            }

            string userInput = txtInput.Text;
            string encryptedMsg = encryptionMachine.Encrypt(userInput);
            txtOutput.Text = encryptedMsg;
        }


    }
}
