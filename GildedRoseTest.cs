using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void TestNormalItem()
        {
            IList<Item> items = new List<Item> { new Item { Name = "NormalItem", SellIn = 5, Quality = 6 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("NormalItem", items[0].Name);
            Assert.AreEqual(4, items[0].SellIn);
            Assert.AreEqual(5, items[0].Quality);

            app.UpdateQuality();
            Assert.AreEqual("NormalItem", items[0].Name);
            Assert.AreEqual(3, items[0].SellIn);
            Assert.AreEqual(4, items[0].Quality);

            app.UpdateQuality();
            Assert.AreEqual("NormalItem", items[0].Name);
            Assert.AreEqual(2, items[0].SellIn);
            Assert.AreEqual(3, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual("NormalItem", items[0].Name);
            Assert.AreEqual(0, items[0].SellIn);
            Assert.AreEqual(1, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual("NormalItem", items[0].Name);
            Assert.AreEqual(-2, items[0].SellIn);
            Assert.AreEqual(0, items[0].Quality);
        }

        [Test]
        public void TestLegendaryItem()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", items[0].Name);
            Assert.AreEqual(5, items[0].SellIn);
            Assert.AreEqual(80, items[0].Quality);

            app.UpdateQuality();
            Assert.AreEqual(5, items[0].SellIn);
            Assert.AreEqual(80, items[0].Quality);
        }

        [Test]
        public void TestAgedBrieItem()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 6 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", items[0].Name);
            Assert.AreEqual(4, items[0].SellIn);
            Assert.AreEqual(7, items[0].Quality);

            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", items[0].Name);
            Assert.AreEqual(3, items[0].SellIn);
            Assert.AreEqual(8, items[0].Quality);

            app.UpdateQuality();
            Assert.AreEqual(2, items[0].SellIn);
            Assert.AreEqual(9, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].SellIn);
            Assert.AreEqual(11, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(-2, items[0].SellIn);
            Assert.AreEqual(15, items[0].Quality);
        }

        [Test]
        public void TestConjuredItem()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 6 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("Conjured", items[0].Name);
            Assert.AreEqual(4, items[0].SellIn);
            Assert.AreEqual(4, items[0].Quality);

            app.UpdateQuality();
            Assert.AreEqual("Conjured", items[0].Name);
            Assert.AreEqual(3, items[0].SellIn);
            Assert.AreEqual(2, items[0].Quality);

            app.UpdateQuality();
            Assert.AreEqual(2, items[0].SellIn);
            Assert.AreEqual(0, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].SellIn);
            Assert.AreEqual(0, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(-2, items[0].SellIn);
            Assert.AreEqual(0, items[0].Quality);
        }

        [Test]
        public void TestBackstagePassesItem()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 6 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", items[0].Name);
            Assert.AreEqual(11, items[0].SellIn);
            Assert.AreEqual(7, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(9, items[0].SellIn);
            Assert.AreEqual(10, items[0].Quality);

            app.UpdateQuality();
            Assert.AreEqual(8, items[0].SellIn);
            Assert.AreEqual(12, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(5, items[0].SellIn);
            Assert.AreEqual(18, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(3, items[0].SellIn);
            Assert.AreEqual(24, items[0].Quality);

            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            app.UpdateQuality();
            Assert.AreEqual(-1, items[0].SellIn);
            Assert.AreEqual(0, items[0].Quality);
        }
    }
}
