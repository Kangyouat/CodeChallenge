using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KangyouaThaoCodeChallenge.Models;

namespace KangyouaThaoCodeChallenge.Services
{
    public class Typing : ITyping
    {
        private readonly Dictionary<string, TypingText> _typingText;

        public Typing()
        {
            _typingText = new Dictionary<string, TypingText>();
        }

        public TypingText AddTexts(TypingText texts)
        {
            _typingText.Add(texts.Text, texts);
            return texts;
        }

        public Dictionary<string, TypingText> GetCountOfText()
        {
            return _typingText;
        }
    }
}
