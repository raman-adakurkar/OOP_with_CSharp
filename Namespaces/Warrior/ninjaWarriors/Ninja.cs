namespace Warrior
{
    public class Ninja
    {
        private int height;
        private int weight;
        private string name;

        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public Ninja(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;
        }
    }
}
