namespace Exercise03Section04
{
    internal class Rectangle
    {
        public double width;
        public double height;

        public double Area()
        {
            return width * height;
        }

        public double Perimeter()
        {
            return 2 * (width + height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(width * width + height * height);
        }
    }
}
