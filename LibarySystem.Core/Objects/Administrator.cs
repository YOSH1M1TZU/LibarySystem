using System.ComponentModel.DataAnnotations;

namespace LibarySystem.Core.Objects {

    public class Administrator {

        [Key]
        public string Login { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }

    }

}