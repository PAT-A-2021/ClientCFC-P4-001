using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel;
using FirstWCFService_001;

namespace FirstWCFService_001
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        /* output->*/
        int Tambah(int a, int b); //method
        [OperationContract]
        int Kurang(int a, int b); //input
        [OperationContract]
        int Kali(int a, int b);
        [OperationContract]
        int Bagi(int a, int b);
        [OperationContract]
        Koordinat TKoordinat(Koordinat a, Koordinat b);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "FirstWCFService_001.ContractType".
    public class Koordinat
    {
        private int _x, _y; //atribut

        public int X //properties
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y //properties
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
