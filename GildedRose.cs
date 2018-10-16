using System.Collections.Generic;

namespace csharp
{
    public enum ItemTypeEnum
    {
        NormalItem = 0,
        AgedBrie = 1,
        BackstagePasses = 2,
        Legendary = 3,
        Conjured = 4
    }

    public class GildedRose
    {
        private readonly string _agedBrie = "Aged Brie";
        private readonly string _backstagePasses = "Backstage passes";
        private readonly string _legendary = "Sulfuras";
        private readonly string _conjured = "Conjured";

        IList<Item> Items;
        public GildedRose(IList<Item> items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                switch (GetItemType(item))
                {
                    case ItemTypeEnum.Legendary:
                        UpdateLegendary(item);
                        break;

                    case ItemTypeEnum.AgedBrie:
                        UpdateAgedBrie(item);
                        break;

                    case ItemTypeEnum.BackstagePasses:
                        UpdateBackstagePasse(item);
                        break;

                    case ItemTypeEnum.Conjured:
                        UpdateConjured(item);
                        break;

                    default :
                        UpdateItem(item);
                        break;
                }

                // Quality is never up to 50
                if (GetItemType(item) != ItemTypeEnum.Legendary && item.Quality > 50) item.Quality = 50;

                // Quality is never negative
                if (item.Quality < 0) item.Quality = 0;
            }
        }

        private void UpdateLegendary(Item item)
        {
            // Nothing to do
        }

        private void UpdateItem(Item item)
        {
            if (GetItemType(item) != ItemTypeEnum.NormalItem) return;

            item.SellIn--;
            item.Quality = item.SellIn < 0 ? item.Quality - 2 : item.Quality - 1;
        }

        private void UpdateAgedBrie(Item item)
        {
            if (GetItemType(item) != ItemTypeEnum.AgedBrie) return;

            item.SellIn--;
            item.Quality = item.SellIn < 0 ? item.Quality + 2 : item.Quality + 1;
        }

        private void UpdateBackstagePasse(Item item)
        {
            if (GetItemType(item) != ItemTypeEnum.BackstagePasses) return;

            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn >= 0 && item.SellIn < 5)
            {
                item.Quality = item.Quality + 3;
            }
            else if (item.SellIn >= 5 && item.SellIn < 10)
            {
                item.Quality = item.Quality + 2;
            }
            else
            {
                item.Quality++;
            }
        }

        private void UpdateConjured(Item item)
        {
            if (GetItemType(item) != ItemTypeEnum.Conjured) return;

            item.SellIn--;
            item.Quality = item.SellIn < 0 ? item.Quality - 4 : item.Quality - 2;
        }

        private ItemTypeEnum GetItemType(Item item)
        {
            if (item.Name.Contains(_legendary)) return ItemTypeEnum.Legendary;
            if (item.Name.Contains(_agedBrie)) return ItemTypeEnum.AgedBrie;
            if (item.Name.Contains(_backstagePasses)) return ItemTypeEnum.BackstagePasses;
            if (item.Name.Contains(_conjured)) return ItemTypeEnum.Conjured;

            return ItemTypeEnum.NormalItem;
        }
    }
}
