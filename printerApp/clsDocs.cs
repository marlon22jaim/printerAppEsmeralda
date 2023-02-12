using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Receipt;

namespace printerApp
{
    public class clsDocs
    {
        public static void Receipt(string saleId, string printerName,int paperSize = 80) { 
            clsTicket ticket1 = new clsTicket();

            string qryDetalle = "SELECT " +
                                "p.name AS product," +
                                "sd.quantity," +
                                "sd.price " +
                                "FROM sale_details AS sd " +
                                "JOIN products AS p ON p.id = sd.product_id " +
                                "WHERE sd.sale_id = " + saleId;

            string qryVenta = "SELECT s.*, u.name AS USER  FROM sales AS s JOIN users AS u ON u.id = s.user_id WHERE s.id = " + saleId;

            DataTable dtDetalle = clsDB.getData(qryDetalle);
            DataTable dtVenta = clsDB.getData(qryVenta);
            DataTable dtCompany = clsDB.getData("SELECT * FROM companies");

            decimal precio = 0, cant = 0;
            double importe = 0;
            string total = "0";
            DateTime fecha = dtVenta.Rows[0].Field<DateTime>("created_at");
            ticket1.SetImpresora("printerName");

        }
    }
}
