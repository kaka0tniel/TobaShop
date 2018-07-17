using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GatewayPyment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool GetData(int id_transaksi, decimal total_harga, string no_kartu, string CVV)
        {
            bool status;
            status = true;//consume dari cc provider
            if (status)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int AddPayment(int id_transaksi, decimal total, string no_kartu, string CVV)
        {
            GatewayPaymentEntities tstDb = new GatewayPaymentEntities();
            GatewayPayment gp = new GatewayPayment();
            gp.id_transaksi = id_transaksi;
            gp.total = total;
            gp.no_kartu = no_kartu;
            gp.CVV = CVV;
            tstDb.GatewayPayments.Add(gp);
            int Retval = tstDb.SaveChanges();
            return Retval;
        }
    }
}
