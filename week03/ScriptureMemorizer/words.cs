using System;

namespace ScriptureMemorizer
{
    /// <summary>
    /// Encapsulates a single word and its hidden/shown state.
    /// </summary>
    public class Word
    {
        private readonly string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            return _isHidden
                ? new string('_', _text.Length)
                : _text;
        }
    }
}
