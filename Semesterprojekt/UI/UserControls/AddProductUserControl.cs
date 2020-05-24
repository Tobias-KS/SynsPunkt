using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistence.CRUD;

namespace UI
{
    public partial class AddProductUserControl : UserControl
    {
        public AddProductUserControl()
        {
            InitializeComponent();
            
        }

        public void CreateProduct()
        {

            string Productname = textBoxProductName.Text;
            int Price = Convert.ToInt32(textBoxPrice.Text);
            string Colour = textBoxColour.Text;
            string Brand = textBoxBrand.Text;
            string FrameType = textBoxFrametype.Text;
            string Glasstype = textBoxGLasstype.Text;
            int RightLensID = Convert.ToInt32(textboxRightlensID.Text);
            int LeftLensID = Convert.ToInt32(textBoxLeftLensID.Text);
            string Productdescription = richTextBoxProductDescription.Text;

            Creator.AddProduct(Productname,Price,Colour,Brand,FrameType,Glasstype,RightLensID,LeftLensID,Productdescription);

        }


    }
}
