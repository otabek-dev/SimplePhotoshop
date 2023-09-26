namespace MyPhotoshop
{
    public class Photo
    {
        public readonly int width;
        public readonly int height;
        public readonly Pixel[,] data;

        public ref Pixel this[int x, int y]
        {
            get => ref data[x, y];
        }

        public Photo(int width, int height)
        {
            this.width = width;
            this.height = height;
            data = new Pixel[width, height];
        }
    }
}

