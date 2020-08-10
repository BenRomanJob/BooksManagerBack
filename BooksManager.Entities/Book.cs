using System;

namespace Domain.Entities
{

    public enum BookType
    {
        ActionAndAdventure,
        Classics,
        ComicBook,
        GraphicNovel,
        Detective,
        Mystery,
        Fantasy,
        Historical,
        Fiction,
        Horror,
        Literary
    }

    public class Book
    {
        public int id { get; set; }
        public BookType type { get; set; }
        public decimal price { get; set; }
        public int pages { get; set; }
        public string name { get; set; }
        public bool isActive { get; set; }
    }
}
