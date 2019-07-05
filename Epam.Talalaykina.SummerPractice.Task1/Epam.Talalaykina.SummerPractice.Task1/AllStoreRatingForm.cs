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
    public partial class AllStoreRatingForm : Form
    {
        private StoreListBL storeListBL = new StoreListBL();
        private UserRatingListBL userRatingListBL = new UserRatingListBL();
        private UserListBL userListBL = new UserListBL();
        int thisStoreID = -1;
        int thisUserID = -1;
        public AllStoreRatingForm()
        {
            InitializeComponent();
        }

        public AllStoreRatingForm(int idUser, int idStore)
        {
            InitializeComponent();
            thisStoreID = idStore;
            thisUserID = idUser;
            storeInfoLabel.Text = storeListBL.GetByID(idStore).ToString();
            if (userRatingListBL.IsRatingExistsByID(idUser, idStore) == 0)
            {
                userStoreRatingInfo.Text = "You haven't add your rating yet.";
            }
            else
            {
                userStoreRatingInfo.Text = userRatingListBL.GetByID(idUser, idStore).ToString();
            }        
            
            
        }

        private void AllStoreRatingForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
