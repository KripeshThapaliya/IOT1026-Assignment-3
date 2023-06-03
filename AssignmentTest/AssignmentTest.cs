using Assignment;
namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            const int PackMaxItems = 10;
            const float PackMaxVolume = 20;
            const float PackMaxWeight = 30;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.AreEqual(pack.GetMaxCount(), PackMaxItems);
        }
        [TestMethod]
        public void VolumeOverflowTest()
        {
            const int PackMaxItems = 1000;
            const float PackMaxVolume = 1;
            const float PackMaxWeight = 3000;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.AreEqual(pack.Add(new Water()), false);
        }
        [TestMethod]
        public void WeightOverflowTest()
        {
            const int PackMaxItems = 1000;
            const float PackMaxVolume = 5000;
            const float PackMaxWeight = 1;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.AreEqual(pack.Add(new Sword()), false);
        }
        [TestMethod]
        public void AddSingleItemToEmptyPackTest()
        {
            const int PackMaxItems = 10;
            const float PackMaxVolume = 20;
            const float PackMaxWeight = 30;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.AreEqual(pack.Add(new Arrow()), true);
        }
        [TestMethod]
        public void AddItemsExceedingConstraintsTest()
        {
            const int PackMaxItems = 2;
            const float PackMaxVolume = 20;
            const float PackMaxWeight = 30;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.AreEqual(pack.Add(new Water()), true);
            Assert.AreEqual(pack.Add(new Food()), true);
            Assert.AreEqual(pack.Add(new Sword()), false);
        }
        [TestMethod]
        public void AddItemsExactConstraintsTest()
        {
            const int PackMaxItems = 4;
            const float PackMaxVolume = 20;
            const float PackMaxWeight = 30;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.AreEqual(pack.Add(new Water()), true);
            Assert.AreEqual(pack.Add(new Food()), true);
            Assert.AreEqual(pack.Add(new Sword()), true);
            Assert.AreEqual(pack.Add(new Bow()), true);
        }
        [TestMethod]
        public void PackClassNegativeValuesTest()
        {
            const int PackMaxItems = -3;
            const float PackMaxVolume = -5;
            const float PackMaxWeight = -10;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);
            Assert.AreEqual(PackMaxItems, pack.GetMaxCount());
        }
    }
}
