using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant1
{
    public class Menu
    {
        public DateTime LastUpdated { get; set; }
        public List<MenuItem> NewDish { get; set; }

        public Menu() { NewDish = new List<MenuItem>();}

        //create method
        //void because it has no return value
        public void AddItem(MenuItem menuItem)
        {
            if (NewDish.Contains(menuItem))
            {
                Console.WriteLine(menuItem.Description + " is already on the menu.");
                return;
            } else {
                NewDish.Add(menuItem);
                LastUpdated = DateTime.Today;
            }
            }
        public void RemoveItem(MenuItem menuItem)
        {
            NewDish.Remove(menuItem);
            LastUpdated = DateTime.Today;
        }
        //all classes come with a two string method
        public override string ToString()
        {
            string output = "Today's Special: \n";
            foreach(MenuItem item in NewDish)
            {
                output += item.Description;
                output += "\n";
                output += item.Price;
                output += "\n";
                output += item.Category;
                output += "\n";
            }
            output += "Last update: " + LastUpdated;
            return output;
        } 
        public string PrintDish(int i)
        {
            NewDish[i];
            string output = "Chef's Specialty: \n";
            foreach (MenuItem item in NewDish.ToArray())
            {
                output += item.Description;
                output += "\n";
                output += item.Price;
                output += "\n";
                output += item.Category;
                output += "\n";
            }
            output += "Last update: " + LastUpdated;
            return output;
        }
    }
}
