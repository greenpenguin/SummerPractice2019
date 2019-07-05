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
    public partial class PersonalAreaForm : Form
    {
        private RegistrationListBL registrationListBL = new RegistrationListBL();
        private UserListBL userListBL = new UserListBL();
        int thisRegistrationID = -1;
        int thisUserID = -1;

        public PersonalAreaForm()
        {
            InitializeComponent();
        }

        public PersonalAreaForm(int registrationID, int userID)
        {
            InitializeComponent();
            thisRegistrationID = registrationID;
            thisUserID = userID;
            registrationInfo.Text = registrationListBL.GetByID(registrationID).ToString();
            userInfo.Text = userListBL.GetByID(userID).ToString();
        }

        private void PersonalAreaForm_Load(object sender, EventArgs e)
        {

        }

        private void changeUserInfoButton_Click(object sender, EventArgs e)
        {
            Form changeUserInfoForm = new ChangeUserInfoForm(thisUserID);
            changeUserInfoForm.ShowDialog();
        }

        private void changeRegistrationInfoButton_Click(object sender, EventArgs e)
        {
            Form changeRegistrationInfoForm = new ChangeRegistrationInfoForm(thisRegistrationID);
            changeRegistrationInfoForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            registrationInfo.Text = registrationListBL.GetByID(thisRegistrationID).ToString();
            userInfo.Text = userListBL.GetByID(thisUserID).ToString();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            registrationListBL.RemoveByID(thisRegistrationID);
            MessageBox.Show("This account is succsessfully deleted!");
            this.Close();
        }

        private void searchStoreByNameButton_Click(object sender, EventArgs e)
        {
            Form searchStoreByNameForm = new SearchStoreByNameForm(thisUserID);
            searchStoreByNameForm.ShowDialog();
        }

        private void addRatingButton_Click(object sender, EventArgs e)
        {
            Form addStoreRatingForm = new AddStoreRatingForm(thisUserID);
            addStoreRatingForm.ShowDialog();
        }
    }
}
