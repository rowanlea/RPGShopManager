using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShopManager
{
    public interface IManageablePerson
    {
        void OperateTill();
        void StockShelves();
        void OrderInventory();
        void CleanShop();
        void HaveBreak();
    }
}
