namespace AysuN.Models
{
    public class Slider
    {
        public Slider(string ımagePath, string title, string description, decimal price)
        {
            ImagePath = ımagePath;
            Title = title;
            Description = description;
            Price = price;
        }

        public string ImagePath {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price {  get; set; }
    }
}
