using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    /// <summary>
    /// Encapsulates a scripture reference plus its words.
    /// Responsible for hiding and displaying words.
    /// </summary>
    public class Scripture
    {
        public Reference Reference { get; }

        private readonly List<Word> _wordList;

        public Scripture(Reference reference, string verseText)
        {
            Reference = reference;
            _wordList = new List<Word>();
            SetWords(verseText);
        }

        private void SetWords(string verseString)
        {
            string[] tokens = verseString.Split(' ');
            foreach (string token in tokens)
            {
                _wordList.Add(new Word(token));
            }
        }

        /// <summary>
        /// Randomly hides up to <paramref name="count"/> currently visible words.
        /// </summary>
        public void HideRandomWords(int count)
        {
            var visibleWords = _wordList.Where(w => !w.IsHidden()).ToList();
            var rnd = new Random();
            for (int i = 0; i < count && visibleWords.Count > 0; i++)
            {
                int idx = rnd.Next(visibleWords.Count);
                visibleWords[idx].Hide();
                visibleWords.RemoveAt(idx);
            }
        }

        public bool IsCompletelyHidden()
        {
            return _wordList.All(w => w.IsHidden());
        }

        public void Display()
        {
            foreach (Word word in _wordList)
                Console.Write(word.GetDisplayText() + " ");
        }
    }
}
