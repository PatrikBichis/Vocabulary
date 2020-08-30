using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Vocabulary.Shared
{
    public class Word
    {
        public Word()
        {
           init("Hej", "Hello");
        }

        public Word(string nativ, string trans)
        {
            init(nativ, trans);
        }

        private void init(string nativ, string trans)
        {
            Native = nativ;
            Translated = trans;
            NrOfComplete = 0;
            NrOfSuccess = 0;
            NrOfFailure = 0;
            NrToComplete = 1;
            Id = Guid.NewGuid().ToString();
        }

        public void Reset()
        {
            NrOfComplete = 0;
        }

        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage ="Måste skriva in ett svenskt ord.")]
        public string Native { get; set; }

        [Required(ErrorMessage = "Måste skriva in det översatta ordet.")]
        public string Translated { get; set; }

        public int NrOfComplete { get; set; }

        public int NrOfSuccess { get; set; }

        public int NrOfFailure { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Måste skriva in ett tal")]
        public int NrToComplete { get; set; }
    }
}
