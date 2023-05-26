namespace Assignment;

static class PackTester
{
    public static void AddEquipment(Pack pack)
    {
        bool addMoreItems = true;
        do
        {
            Console.WriteLine(pack); // See output image for what this should display

            Console.WriteLine("What do you want to add?");
            Console.WriteLine("1 - Arrow");
            Console.WriteLine("2 - Bow");
            Console.WriteLine("3 - Rope");
            Console.WriteLine("4 - Water");
            Console.WriteLine("5 - Food");
            Console.WriteLine("6 - Sword");
            Console.WriteLine("7 - Gather your pack and venture forth");

            try
            {
                // int.TryParse should be preferred
                // I am using this method to demonstrate exception handling
                int choice = Convert.ToInt32(Console.ReadLine());
                // Can use _ -> for a default case to possibly avoid exception handling
                InventoryItem newItem = choice switch
                {
                    1 => new Arrow(),
                    2 => new Bow(),
                    3 => new Rope(),
                    4 => new Water(),
                    5 => new Food(),
                    6 => new Sword()
                };
                if (!pack.Add(newItem))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Could not fit this item into the pack.");
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is an invalid selection.");
            }
            // If the user enters an int that is not covered by our switch statement
            // we break out of the loop (good design choice?)
            catch (System.Runtime.CompilerServices.SwitchExpressionException)
            {
                Console.WriteLine("Venturing Forth!");
                addMoreItems = false;
            }
            Console.ResetColor();
        } while (addMoreItems);
    }
}
