namespace MvcApp.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using MvcApp.Models;

    [Route("api/[Controller]")]
    public class QuizController: Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var quiz = new QuizDto {
                Definitions = new List<WordDto>{
                    new WordDto
                    {
                        Id = 1,
                        Word = "erudite",
                        Definition = "having or showing great knowledge or learning."
                    },
                    new WordDto
                    {
                        Id = 2,
                        Word = "panegyric",
                        Definition = "a public speech or published text in praise of someone or something."
                    }
                }
            };

            return Ok(quiz);
        }
    } 
}