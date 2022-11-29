using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    // було порушено принцип єдиного обов'язку (SRP - Single Responsibility Principle)
    // виправлений варіант - class Order розбито на кілька менших згідно з обов'язками
    class Item
    {

    }
    public class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }
    }

    public class WorkWithItem
    {
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    public class Repository
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    public class OrderManager
    {
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }

    public class Program
    {
        static void Main()
        {
        }
    }
}