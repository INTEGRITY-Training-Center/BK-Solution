using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;
namespace ygMerceController
{
    public class Cell_PriceController
    {
        Cell_PriceDAO cpDao = new Cell_PriceDAO();
        List<Cell_Priceinfoinfo> lstCellPrice;

        public List<Cell_Priceinfoinfo> SelectAllCellPrice()
        {
            lstCellPrice = new List<Cell_Priceinfoinfo>();
            lstCellPrice = cpDao.SelectAllCellPrice();

            return lstCellPrice;
        }
        public void InsertCell_Price(Cell_Priceinfoinfo cinfo)
        {
            cpDao.InsertCellPrice(cinfo);
        }
        public void UpdateCell_Price(Cell_Priceinfoinfo cinfo)
        {
            cpDao.UpdateCell_PriceByID(cinfo);
        }
        public void DeleteCell_Price(Cell_Priceinfoinfo cinfo)
        {
            cpDao.DeleteCell_PriceByID(cinfo);
        }

    }
}
