using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KangyouaThaoCodeChallenge.Models;
using KangyouaThaoCodeChallenge.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KangyouaThaoCodeChallenge.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly ITyping _typing;

        public TextController(ITyping typing)
        {
            _typing = typing;
        }

        [HttpPost]
        [Route("AddTexts")]
        public ActionResult<TypingText> AddTexts(TypingText texts)
        {
            var typingTexts = _typing.AddTexts(texts);
            var userId = typingTexts.Id;
            var userText = typingTexts.Text;
            var count = typingTexts.Text.Length;

            var d = new TypingText();
            d.Id = userId;
            d.Text = userText;
            d.CountOfChars = count;

            return d;

        }

        [HttpGet]
        [Route("GetCountOfText")]
        public ActionResult<Dictionary<string, TypingText>> GetCountOfText()
        {
            var typingTexts = _typing.GetCountOfText();

            if (typingTexts.Count == 0)
            {
                return NotFound();
            }

            return typingTexts;
        }

    }
}