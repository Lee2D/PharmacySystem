using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntities;

namespace PharmacySystem
{
    public partial class frmViewStockItemDetails : Form
    {
        private IModel Model;
        private int itemID;
        public frmViewStockItemDetails(IModel model, int id)
        {
            InitializeComponent();
            this.Model = model;
            this.itemID = id;
        }

        private void frmViewStockItemDetails_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString(); // show the durrent time
            lblDate.Text = DateTime.Now.ToLongDateString(); // show the current date
            //timer1.Start(); // Start time 

            foreach (Item item in Model.ItemList)
            {
                //get gp details
                if (item.ItemID == itemID)
                {
                    txtItemID.Text = item.ItemID.ToString();
                    txtName.Text = item.ItemName.ToString();
                    txtQuantity.Text = item.Quantity.ToString();
                    txtPurchaseUnit.Text = item.PurchaseUnit.ToString();
                    txtVendor.Text = item.Vendor.ToString();        
                    txtDescription.Text = item.Description.ToString();
                    txtSale.Text = item.SaleUnit.ToString();
                    break;
                }
            }
        }
    }
}
