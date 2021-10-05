using System;

namespace Restaurant1
{
    class Program
    {
        static void Main (string[] args)
        {
            MenuItem coffee = new MenuItem(4, "black coffee", "drink");
            MenuItem blueberryscones = new MenuItem(2, "Blueberry Scones", "pastry");
            MenuItem omelette = new MenuItem(7, "Omelette", "food");
            MenuItem croissant = new MenuItem(7, "Ham and Cheese Croissant", "sandwich");
            Menu kenMenu = new Menu();
            kenMenu.AddItem(coffee);
            //kenMenu.RemoveItem(coffee);
            //kenMenu.AddItem(coffee);
            //kenMenu.RemoveItem(coffee);
            kenMenu.AddItem(blueberryscones);
            kenMenu.AddItem(omelette);
            kenMenu.AddItem(croissant);



            Console.WriteLine(kenMenu[0]);
          //Console.WriteLine(kenMenu.ToString());
        }

    }
  
}
