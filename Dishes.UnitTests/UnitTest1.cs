using ClassDish;
namespace Dishes.UnitTests
{
    [TestFixture]
    public class DishUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var karbonara = CreateTestDish();

            Assert.That(karbonara.NameOfDish, Is.EqualTo("Карбонара"));
            Assert.That(karbonara.Kitchen, Is.EqualTo(KitchenName.Итальянская));
            Assert.That(karbonara.AboutTheDish, Is.EqualTo("паста с яичным соусом, сыром и беконом."));
            Assert.That(karbonara.Price, Is.EqualTo(40));
            Assert.That(karbonara.DishExistence, Is.EqualTo(true));
            Assert.That(karbonara.CookingTime, Is.EqualTo(20));
        }

        [Test]
        public void GetInfoTest()
        {
            var karbonara = CreateTestDish();
            var info = karbonara.GetInfo();

            Assert.That(info.Length, Is.EqualTo(6));
            Assert.That(info[0], Is.EqualTo("Название: Карбонара"));
            Assert.That(info[1], Is.EqualTo("Кухня: Итальянская"));
            Assert.That(info[2], Is.EqualTo("Описание: паста с яичным соусом, сыром и беконом."));
            Assert.That(info[3], Is.EqualTo("Цена: 40 руб."));
            Assert.That(info[4], Is.EqualTo("Наличие: в наличии"));
            Assert.That(info[5], Is.EqualTo("Время приготовления: 20 минут"));

        }

        private Dish CreateTestDish()
        {
            return new Dish("Карбонара", KitchenName.Итальянская, "паста с яичным соусом, сыром и беконом.", 40, true, 20);
        }
    }
}
