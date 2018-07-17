using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GatewayPyment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        bool GetData(int id_transaksi, decimal total_harga, string no_kartu, string CVV);

        [OperationContract]
        int AddPayment(int id_transaksi, decimal total, string no_kartu, string CVV);
        // TODO: Add your service operations here
    }

    [DataContract]
    public class GatewayPayments
    {
        [DataMember]
        public int id_transaksi { get; set; }

        [DataMember]
        public decimal total { get; set; }

        [DataMember]
        public string no_kartu { get; set; }

        [DataMember]
        public string CVV { get; set; }

    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}  