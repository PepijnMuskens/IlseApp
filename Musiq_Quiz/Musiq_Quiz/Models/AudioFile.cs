using System.ComponentModel.DataAnnotations.Schema;

namespace MusicQuiz.Models
{
    public class AudioFile
    {
        public int Id { get; set; }
        public byte[] AudioData { get; set; }
    }
}
