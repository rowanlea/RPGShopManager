using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopManager
{
    public class Shop
    {
        private IManageablePerson workerA;
        private IManageablePerson workerB;

        public Shop(IManageablePerson workerA, IManageablePerson workerB)
        {
            this.workerA = workerA;
            this.workerB = workerB;
        }

        public void RunForOneDay()
        {
            throw new NotImplementedException();
        }

        public void SendCustomers(int v)
        {
            throw new NotImplementedException();
        }
    }
}
