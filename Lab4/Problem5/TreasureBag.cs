using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Problem5
{
    public class TreasureBag
    {
        private Dictionary<string, Dictionary<string, long>> bag;

        public TreasureBag(int capacity)
        {
            Capacity = capacity;
            bag = new Dictionary<string, Dictionary<string, long>>();
        }

        public int Capacity { get; private set; }

        public void AddItem(string item, long quantity)
        {
            string itemType = GetItemType(item);

            if (itemType == null)
                return;

            if (!bag.ContainsKey(itemType))
                bag[itemType] = new Dictionary<string, long>();

            if (!bag[itemType].ContainsKey(item))
                bag[itemType][item] = 0;

            bag[itemType][item] += quantity;

            if (!IsBagValid())
                bag[itemType][item] -= quantity;
            bag[itemType].Remove(item);
        }

        private string GetItemType(string item)
        {
            if (item.Length == 3 && item.All(char.IsLetter))
                return "Cash";

            if (item.ToLower().EndsWith("gem") && item.Length >= 4)
                return "Gem";

            if (item.ToLower() == "gold")
                return "Gold";

            return null;

            return null;
        }

        private bool IsBagValid()
        {
            long goldAmount = bag.ContainsKey("Gold") ? bag["Gold"].Values.Sum() : 0;
            long gemAmount = bag.ContainsKey("Gem") ? bag["Gem"].Values.Sum() : 0;
            long cashAmount = bag.ContainsKey("Cash") ? bag["Cash"].Values.Sum() : 0;

            return goldAmount >= gemAmount && gemAmount >= cashAmount && goldAmount + gemAmount + cashAmount <= Capacity;
        }

        public void PrintResult()
        {
            foreach (var itemType in bag.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"<{itemType.Key}> ${itemType.Value.Values.Sum()}");

                foreach (var item in itemType.Value.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                    Console.WriteLine($"##{item.Key} - {item.Value}");
            }
        }
    }
}
