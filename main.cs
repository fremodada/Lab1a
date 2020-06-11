using System;

class MainClass {
  public static void Main (string[] args) {


    // Get input
    Console.WriteLine ("Enter Item Name");
    string itemName = Console.ReadLine();
    Console.WriteLine("Enter Item Quantity (only whole numbers)");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Item Price");
    double price = Convert.ToDouble(Console.ReadLine());
    // Calculate Total Price
   double totalPrice = quantity * price;
   // Display output
   Console.WriteLine("Total price of " + itemName + " is $" + totalPrice );
  }
}