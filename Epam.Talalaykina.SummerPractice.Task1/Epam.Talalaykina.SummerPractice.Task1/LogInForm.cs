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
    public partial class LogInForm : Form
    {
        private RegistrationListBL registrationListBL = new RegistrationListBL();

        public LogInForm()
        {
            InitializeComponent();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if ((loginTextBox.Text == "") || (passwordTextBox.Text == ""))
            {
                MessageBox.Show("Please, enter your login and/or password!");
            }
            else
            {
                if (registrationListBL.IsIRegistrationRecordExistsByLogAndPass(loginTextBox.Text, passwordTextBox.Text) == 0)
                {
                    Console.WriteLine("oops");
                    MessageBox.Show("Wrong login and/or password!");
                }
                else
                {
                    Console.WriteLine("ok");
                    //go to lk
                    Form personalAreaForm = new PersonalAreaForm(registrationListBL.IsIRegistrationRecordExistsByLogAndPass(loginTextBox.Text, passwordTextBox.Text),
                        registrationListBL.IsIRegistrationRecordExistsByLog(loginTextBox.Text));
                    personalAreaForm.ShowDialog();
                }
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            Form newUserForm = new CreateNewUserForm();
            newUserForm.ShowDialog();
        }
    }
}
