using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vocabulary.Shared
{
    public class EnteredWord
    {
        [Required]
        public string Word { get; set; }

        public bool IsCorrect { get; set; } = false;

        public bool IsToShort { get; set; } = false;

        public bool IsToLong { get; set; } = false;

        public bool IsNew { get; set; } = true;

        public int[] WrongLetter { get; set; } = new int[0];
    }
}
