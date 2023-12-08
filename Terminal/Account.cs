using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    
    internal class Account
    {
        public delegate void AccounDel(object sender, AccountEventArgs e);
        public event AccounDel EventSum;
        public event AccounDel EventGet;
        public int Sum { get; set; }
        public Account(int sum)
        {
            Sum = sum;
            //message
        }
        public void Put(int sum)
        {
            Sum+= sum;
            if (EventSum != null) EventSum(this, new AccountEventArgs($"Sum put: {sum} balance: {Sum}", sum));
        }
        public void Get(int sum)
        {
            if (Sum >= sum)
            { 
                Sum -= sum;
                if (EventGet != null) { EventGet(this, new AccountEventArgs($"Sum get: {sum} balance: {Sum}", sum)); }
            }
            else
            {
                EventGet(this, new AccountEventArgs($"Not enough money,  balance: {Sum}", sum));
            }
        }
    }
}
