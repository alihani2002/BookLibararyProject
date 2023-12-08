namespace BookLibarary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public bool IsOfTheMonth { get; set; }
        public string CoverPhoto { get; set; }

        //Navigation Property
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
