namespace Assignment;

class Pack
{
    private InventoryItem[] _items; // You can use another data structure here if you prefer.
    // You may need another private member variable if you use an array data structure.

    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        throw new NotImplementedException();
    }

    public bool Add(InventoryItem item)
    {
        throw new NotImplementedException();
    }

    // Implement this class
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}

class InventoryItem
{
    // Implement this class
}

// Implement these classes - each inherits from InventoryItem
// 1 line of code each - call base class constructor with appropriate arguments
class Arrow : InventoryItem { }
class Bow : InventoryItem { }
class Rope : InventoryItem { }
class Water : InventoryItem { }
class Food : InventoryItem { }
class Sword : InventoryItem { }
