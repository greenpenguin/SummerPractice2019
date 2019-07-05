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
    public partial class SearchStoreByNameForm : Form
    {
        private StoreListBL storeListBL = new StoreListBL();
        int thisUserID = -1;

        public SearchStoreByNameForm()
        {
            InitializeComponent();
        }

        public SearchStoreByNameForm(int idUser)
        {
            InitializeComponent();
            thisUserID = idUser;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (storeNameTextBox.Text == "")
            {
                MessageBox.Show("Please, fill the field!");
            }
            else
            {
                if (storeListBL.IsStoreExistsByStoreName(storeNameTextBox.Text) == 0)
                {
                    MessageBox.Show("There is not store with this name!");
                }
                else
                {
                    //all store rating
                    
                    Form allStoreRatingForm = new AllStoreRatingForm(thisUserID, storeListBL.IsStoreExistsByStoreName(storeNameTextBox.Text));
                    allStoreRatingForm.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
