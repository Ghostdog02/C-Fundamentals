

namespace Telephone
{
    public class Screen
    {
        private string? size = null;
        private string? color = null;

        public string? Size { get => size; set => size = value; }

        public string? Color { get => color; set => color = value; }

        public Screen(string? size)
    : this(size, null)
        {

        }

        public Screen(string? size, string? color)
        {
            this.Size = size;
            this.Color = color;
        }
    }
}
