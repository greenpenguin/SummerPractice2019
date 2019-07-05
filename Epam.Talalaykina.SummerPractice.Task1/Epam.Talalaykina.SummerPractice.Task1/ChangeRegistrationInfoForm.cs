using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.Talalaykina.SummerPractice.Task1
{
    public partial class ChangeRegistrationInfoForm : Form
    {
        private RegistrationListBL registrationListBL = new RegistrationListBL();
        int thisRegistrationID = -1;

        public ChangeRegistrationInfoForm()
        {
            InitializeComponent();
        }

        public ChangeRegistrationInfoForm(int registrationID)
        {
            InitializeComponent();
            thisRegistrationID = registrationID;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if ((newLoginTextBox.Text == "") || (newPasswordTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all the fields!");
            }
            else
            {
                if (registrationListBL.IsIRegistrationRecordExistsByLogAndPass(newLoginTextBox.Text, newPasswordTextBox.Text) != 0)
                {
                    Console.WriteLine("login exists");
                    MessageBox.Show("This login is already exists!");
                }
                else
                {
                    registrationListBL.UpdateByID(thisRegistrationID, newLoginTextBox.Text, newPasswordTextBox.Text);
                    MessageBox.Show("Login and/or password updated succsessfully!");

                    this.Close();
                }
            }
        }
    }
}
