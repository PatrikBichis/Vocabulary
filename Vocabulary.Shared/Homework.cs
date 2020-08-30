using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vocabulary.Shared
{
    public class Homework
    {
        public Homework()
        {
            Description = "";
            DueDate = DateTime.Now;
            Language = "Svenska";

            Id = Guid.NewGuid().ToString();

            Words = new List<Word>();
        }

        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Måste ge läxan ett namn")]
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Måste völja ett språk")]
        public string Language { get; set; }

        public ICollection<Word> Words { get; set; } 
    }
}
