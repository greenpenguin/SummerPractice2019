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
    public partial class AddStoreRatingForm : Form
    {
        private RegistrationListBL registrationListBL = new RegistrationListBL();
        private UserListBL userListBL = new UserListBL();
        private StoreListBL storeListBL = new StoreListBL();
        private UserRatingListBL userRatingListBL = new UserRatingListBL();
        int thisUser = -1;
        public AddStoreRatingForm()
        {
            InitializeComponent();
        }

        public AddStoreRatingForm(int userID)
        {
            InitializeComponent();
            thisUser = userID;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((storeNameTextBox.Text == "") || (assortComboBox == null) || (pLevelComboBox == null) || (servRatComboBox == null))
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                if (userRatingListBL.IsRatingExistsByID(thisUser, storeListBL.IsStoreExistsByStoreName(storeNameTextBox.Text)) != 0)
                {
                    MessageBox.Show("You have already add rating for this store, it will be updated.");
                    
                    userRatingListBL.UpdateByID(thisUser, storeListBL.IsStoreExistsByStoreName(storeNameTextBox.Text),
                        int.Parse(assortComboBox.Text), int.Parse(pLevelComboBox.Text), int.Parse(servRatComboBox.Text));
                    this.Close();
                }
                else if (storeListBL.IsStoreExistsByStoreName(storeNameTextBox.Text) == 0)
                {
                    MessageBox.Show("There is not store with this name, it will be created.");
                    storeListBL.Add(new Entities.StoreList(storeNameTextBox.Text));
                    userRatingListBL.Add(new Entities.UserRatingList(thisUser, storeListBL.IsStoreExistsByStoreName(storeNameTextBox.Text),
                        int.Parse(assortComboBox.Text), int.Parse(pLevelComboBox.Text), int.Parse(servRatComboBox.Text)));
                    this.Close();
                }
                else
                {
                    userRatingListBL.Add(new Entities.UserRatingList(thisUser, storeListBL.IsStoreExistsByStoreName(storeNameTextBox.Text),
                        int.Parse(assortComboBox.Text), int.Parse(pLevelComboBox.Text), int.Parse(servRatComboBox.Text)));

                    MessageBox.Show("New rating record added succsessfully!");
                    this.Close();
                }
            }
        }
    }
}
