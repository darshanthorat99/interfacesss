using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesss
{
    public interface ICustomer
    {
        string Detail();
    }
    public interface IOrder
    {
        string Detail();
    }
    public  class Transaction:ICustomer,IOrder
    {
        public int cid, orderno,total_amt,no_iteam;
        public string name;
        public long  num;

        public Transaction(int cid ,int orderno,int total_amt,int no_iteam,string name,long num )
        {
            this.cid = cid;
            this.orderno = orderno;
            this.total_amt = total_amt;
            this.no_iteam = no_iteam;
            this.name = name;
            this.num = num;
        }
        string IOrder.Detail()
        {
            return$"order no{orderno}  total amount{total_amt} no of iteam{no_iteam}\n";
        }
        string ICustomer.Detail()
        {
            return $"customer name {name} customer id{cid} customer number{num}";
        }
    }
}
