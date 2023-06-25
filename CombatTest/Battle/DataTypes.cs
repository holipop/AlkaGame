namespace DataTypes
{
    class Type
    {
        private string color;
        private string name;
        public string getColor() { return color; }
        public string getName() { return name; }
        public void setColor(string color) { this.color = color; }
        public void setName(string name) { this.name = name; }
    }

    class Move
    {
        private Type type;
        private string style;
        private int damage;
    }
}