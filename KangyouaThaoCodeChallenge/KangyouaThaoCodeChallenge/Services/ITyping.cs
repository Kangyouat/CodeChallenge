using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KangyouaThaoCodeChallenge.Models;

namespace KangyouaThaoCodeChallenge.Services
{
    public interface ITyping
    {
        TypingText AddTexts(TypingText texts);
        Dictionary<string, TypingText> GetCountOfText();
    }
}
