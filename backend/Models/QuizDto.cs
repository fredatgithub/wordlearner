
namespace MvcApp.Models
{
    using System.Collections.Generic;

    public class QuizDto
    {
        public QuizDto()
        {
            Definitions = new List<WordDto>();
        }
        public IEnumerable<WordDto> Definitions { get; set; }
    }   
}

