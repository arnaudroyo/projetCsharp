namespace CsharpB2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetcsharp.personne")]
    public partial class personne
    {
        [Required]
        [StringLength(50)]
        public string nom { get; set; }

        [Required]
        [StringLength(50)]
        public string prenom { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ville { get; set; }
    }
}
