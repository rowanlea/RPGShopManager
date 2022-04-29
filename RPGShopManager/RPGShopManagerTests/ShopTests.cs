using NSubstitute;
using NUnit.Framework;
using RPGShopManager;

namespace RPGShopManagerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenShopRunsForWholeDay_BothWorkersWillHavePerformedEachTaskAtLeastOnce()
        {
            IManageablePerson workerA = Substitute.For<IManageablePerson>();
            IManageablePerson workerB = Substitute.For<IManageablePerson>();
            Shop shop = new Shop(workerA, workerB);
            shop.RunForOneDay();

            workerA.Received().OperateTill();
            workerA.Received().StockShelves();
            workerA.Received().OrderInventory();
            workerA.Received().CleanShop();
            workerA.Received().HaveBreak();

            workerB.Received().OperateTill();
            workerB.Received().StockShelves();
            workerB.Received().OrderInventory();
            workerB.Received().CleanShop();
            workerB.Received().HaveBreak();
        }

        [Test]
        public void WhenShopRunsForWholeDay_AndISendACustomer_ItemsGetBought_ItemsGetSold_ShopMakesAProfit()
        {
            IManageablePerson workerA = Substitute.For<IManageablePerson>();
            IManageablePerson workerB = Substitute.For<IManageablePerson>();
            Shop shop = new Shop(workerA, workerB);
            shop.RunForOneDay();
            shop.SendCustomers(1);

            Assert.IsTrue(false);
        }

        [Test]
        public void WhenShopRunsForWholeDay_AndISendACustomer_StockGetsSold_StockGetsOrdered()
        {
            IManageablePerson workerA = Substitute.For<IManageablePerson>();
            IManageablePerson workerB = Substitute.For<IManageablePerson>();
            Shop shop = new Shop(workerA, workerB);
            shop.RunForOneDay();
            shop.SendCustomers(1);

            Assert.IsTrue(false);
        }

        [Test]
        public void WhenShopRunsForTwoDays_AndISendACustomerEachDay_StockGetsSold_StockGetsOrdered_StockGetsShelved()
        {
            IManageablePerson workerA = Substitute.For<IManageablePerson>();
            IManageablePerson workerB = Substitute.For<IManageablePerson>();
            Shop shop = new Shop(workerA, workerB);
            shop.RunForOneDay();
            shop.SendCustomers(1);

            Assert.IsTrue(false);
        }
    }
}