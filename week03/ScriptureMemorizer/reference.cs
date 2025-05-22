using System;

namespace ScriptureMemorizer
{
    /// <summary>
    /// Encapsulates a scripture reference (book, chapter, verse range).
    /// </summary>
    public class Reference
    {
        private readonly string _book;
        private readonly int _chapter;
        private readonly int _startVerse;
        private readonly int _endVerse;

        public Reference(string book, int chapter, int verse)
            : this(book, chapter, verse, verse)
        {
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public void Display()
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}");
            if (_endVerse != _startVerse)
                Console.Write($"–{_endVerse}");
        }
    }
}
