using System.ComponentModel.DataAnnotations;

namespace OsobyZaginione.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime DateMissing { get; set; }
        public string LastSeenPlace { get; set; }
        public bool IsFound { get; set; } = false;



    }
}
