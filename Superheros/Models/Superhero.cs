using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superheros.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayName("Alter Ego")]
        public string AlterEgo { get; set; }

        [DisplayName("Primary Ability")]
        public string PrimaryAbility {get; set; }

        [DisplayName("Secondary Ability")]
        public string SecondaryAbility { get; set; }

        [DisplayName("Catchphrase")]
        public string CatchPhrase{ get; set; }


    }
}
