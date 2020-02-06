using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;
namespace ygMerceController
{
    public class Cell_Price_HistoryController
    {
        Cell_Price_HistoryDAO cphDao = new Cell_Price_HistoryDAO();
        List<Cell_Price_Historyinfo> lstCellPriceHistory ;

        public List<Cell_Price_Historyinfo> SelectAllCellPriceHistory()
        {
            lstCellPriceHistory = new List<Cell_Price_Historyinfo>();
            lstCellPriceHistory = cphDao.SelectAllCellPriceHistoryinfo();
           
            return lstCellPriceHistory;
        }
        public void InsertCell_Price_History(Cell_Price_Historyinfo cinfo)
        {
            cphDao.InsertCellPriceHistory(cinfo);
        }
        public void UpdateCell_Price_History(Cell_Price_Historyinfo cinfo)
        {
            cphDao.DeleteCell_Price_HistoryByID(cinfo);
        }
        public void DeleteCell_Price_History(Cell_Price_Historyinfo cinfo)
        {
            cphDao.DeleteCell_Price_HistoryByID(cinfo);
        }
    }
}
