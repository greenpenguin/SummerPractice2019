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
    public partial class CreateNewUserForm : Form
    {
        private RegistrationListBL registrationListBL = new RegistrationListBL();
        private UserListBL userListBL = new UserListBL();

        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if ((loginTextBox.Text == "") || (passwordTextBox.Text == "") || (usernameTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                if (registrationListBL.IsIRegistrationRecordExistsByLog(loginTextBox.Text) != 0)
                {
                    Console.WriteLine("login exists");
                    MessageBox.Show("This login is already exists!");
                }
                else if (userListBL.IsUserExistsByUsername(usernameTextBox.Text) != 0)
                {
                    Console.WriteLine("username exists");
                    MessageBox.Show("This username is already exists!");
                }
                else
                {
                    Console.WriteLine("ok");
                    userListBL.Add(new Entities.UserList(usernameTextBox.Text));
                    registrationListBL.Add(new Entities.RegistrationList(userListBL.IsUserExistsByUsername(usernameTextBox.Text), loginTextBox.Text, passwordTextBox.Text));
                    //go to lk
                    MessageBox.Show("New account created succsessfully!");
                    Form personalAreaForm = new PersonalAreaForm(registrationListBL.IsIRegistrationRecordExistsByLogAndPass(loginTextBox.Text, passwordTextBox.Text),
                        registrationListBL.IsIRegistrationRecordExistsByLog(loginTextBox.Text));
                    personalAreaForm.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
