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
    public partial class ChangeUserInfoForm : Form
    {
        private UserListBL userListBL = new UserListBL();
        int thisUserID = -1;

        public ChangeUserInfoForm()
        {
            InitializeComponent();
        }

        public ChangeUserInfoForm(int userID)
        {
            InitializeComponent();
            thisUserID = userID;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if ((newLoginTextBox.Text == ""))
            {
                MessageBox.Show("Please, fill the field!");
            }
            else
            {
                if (userListBL.IsUserExistsByUsername(newLoginTextBox.Text) != 0)
                {
                    Console.WriteLine("username exists");
                    MessageBox.Show("This username is already exists!");
                }
                else
                {
                    userListBL.UpdateByID(thisUserID, newLoginTextBox.Text);
                    MessageBox.Show("Username updated succsessfully!");
                    
                    this.Close();
                }
            }
        }
    }
}
