using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceController;
using ygMerceInfo;

namespace ygMerce
{
    public partial class tstProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<brandinfoinfo> brLst = new List<brandinfoinfo>();
            List<SupplierInfo> supLst = new List<SupplierInfo>();
            List<Categoryinfo> catLst = new List<Categoryinfo>();
            List<UnitOfMeasureInfo> umLst = new List<UnitOfMeasureInfo>();
            BrandController brcon = new BrandController();
            SupplierController supcon = new SupplierController();
            CategoryController catcon = new CategoryController();
            UnitOfMeasureController umcon = new UnitOfMeasureController();

            if (!IsPostBack)
            {

                //brLst = brcon.SelectAllBrandInfo();
                //ddlBrand.DataSource = brLst;
                //ddlBrand.DataTextField = "BrandName";
               
                //ddlBrand.DataBind();
                ddlBrand.Items.Insert(0, new ListItem("-- Select Brand --", ""));

                supLst = supcon.SelectAllSupplierInfo();
                ddlSupplier.DataSource = supLst;
                ddlSupplier.DataTextField = "SupplierName";
                ddlSupplier.DataBind();
                ddlSupplier.Items.Insert(0, new ListItem("-- Select Supplier --", ""));

                catLst = catcon.SelectAllCategoryInfo();
                ddlCateogry.DataSource = catLst;
                ddlCateogry.DataTextField = "Type";
                ddlCateogry.DataBind();
                ddlCateogry.Items.Insert(0, new ListItem("-- Select Category --", ""));

                umLst = umcon.SelectAllUnitOfMeasureInfo();
                ddlUM.DataSource = umLst;
                ddlUM.DataTextField = "UMDescription";
                ddlUM.DataBind();
                ddlUM.Items.Insert(0, new ListItem("-- Select UM --", ""));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Productinfo prinfo = new Productinfo();
            ProductController pcon = new ProductController();
            prinfo.ProductName = txtProductName.Text.Trim();
            prinfo.Product_description = txtDesc.Text.Trim();
            prinfo.Color = txtColor.Text.Trim();
            prinfo.Size = txtSize.Text.Trim();
            prinfo.Manufacture_Country = txtMade.Text.Trim();
            prinfo.UnitPrice = Convert.ToDecimal(txtSellPrice.Text.Trim());
            prinfo.Manufacture_date = Convert.ToDateTime( txtManuDate.Text.Trim());
            prinfo.Expired_date = Convert.ToDateTime(txtExpDate.Text.Trim());
            prinfo.Product_Expired_date = Convert.ToDateTime(txtExpDate.Text.Trim());
            prinfo.BrandID = ddlBrand.SelectedItem.Value;
            prinfo.CategoryID = ddlCateogry.SelectedItem.Value;
            prinfo.SupplierID = ddlSupplier.SelectedItem.Value;
            prinfo.UMID = ddlUM.SelectedItem.Value;
            //pcon.InsertProduct(prinfo);
            
            string productID = pcon.InsertProduct(prinfo);

            Inventoryinfo invinfo = new Inventoryinfo();
            Invertorycontroller invCon = new Invertorycontroller();
            invinfo.ProductID = productID;
            invinfo.UnitInStock = Convert.ToInt32(txtUnitStock.Text.Trim());

            string invId= invCon.InsertInventory(invinfo);

            ReorderInfo rinfo = new ReorderInfo();
            ReorderController rcon = new ReorderController();

            rinfo.ProductID = productID;
            rinfo.InventoryID = invId;
            rinfo.ReorderUnit = txtReorder.Text.Trim();

            rcon.InsertReorder(rinfo);

            Cell_Priceinfoinfo cinfo=new Cell_Priceinfoinfo ();
            Cell_PriceController ccon = new Cell_PriceController();
            cinfo.Cell_Price1 = Convert.ToDecimal(txtBuyPrice.Text.Trim());
            cinfo.Cell_Price2 = Convert.ToDecimal(txtSellPrice.Text.Trim());
            cinfo.Product_id = productID;
            cinfo.UMID = ddlUM.SelectedItem.Value;

            ccon.InsertCell_Price(cinfo);

            if (fuMain.HasFile)
            {
                product_imageinfo piminfo = new product_imageinfo();
                ProductImageController pimcon = new ProductImageController();
                piminfo.ProductID = productID;
                piminfo.Images = fuMain.FileBytes;
                piminfo.MainPic = true;
                pimcon.InsertProductImage(piminfo);
            }
            if (fuLeft.HasFile)
            {
                product_imageinfo piminfo = new product_imageinfo();
                ProductImageController pimcon = new ProductImageController();
                piminfo.ProductID = productID;
                piminfo.Images = fuLeft.FileBytes;

                pimcon.InsertProductImage(piminfo);
            }
            if (FuBehind.HasFile)
            {
                product_imageinfo piminfo = new product_imageinfo();
                ProductImageController pimcon = new ProductImageController();
                piminfo.ProductID = productID;
                piminfo.Images = FuBehind.FileBytes;
                piminfo.MainPic = false;
                pimcon.InsertProductImage(piminfo);
            }
            if (fuRight.HasFile)
            {
                product_imageinfo piminfo = new product_imageinfo();
                ProductImageController pimcon = new ProductImageController();
                piminfo.ProductID = productID;
                piminfo.Images = fuRight.FileBytes;
                piminfo.MainPic = false;
                pimcon.InsertProductImage(piminfo);
            }
            if (fuFront.HasFile)
            {
                product_imageinfo piminfo = new product_imageinfo();
                ProductImageController pimcon = new ProductImageController();
                piminfo.ProductID = productID;
                piminfo.Images = fuFront.FileBytes;
                piminfo.MainPic = false;
                pimcon.InsertProductImage(piminfo);
            }
            if (fuBottom.HasFile)
            {
                product_imageinfo piminfo = new product_imageinfo();
                ProductImageController pimcon = new ProductImageController();
                piminfo.ProductID = productID;
                piminfo.Images = fuBottom.FileBytes;
                piminfo.MainPic = false;
                pimcon.InsertProductImage(piminfo);
            }

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('New Product Inserted Successfully!')", true);



        }

        protected void ddlCateogry_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<brandinfoinfo> blst = new List<brandinfoinfo>();
            BrandController bcon = new BrandController();
            blst = bcon.SelectAllBrandInfoByCategoryID(ddlCateogry.SelectedItem.Value);
            ddlBrand.DataSource = blst;
            ddlBrand.DataTextField = "BrandName";

            ddlBrand.DataBind();
            ddlBrand.Items.Insert(0, new ListItem("-- Select Brand --", ""));
        }
    }
}