using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicQuiz.Data.Models
{
    public class AudioFile
    {
        public int Id { get; set; }
        [Column(TypeName = "LONGBLOB")]
        public byte[] AudioData { get; set; }
    }
}
