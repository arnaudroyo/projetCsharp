namespace CsharpB2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetcsharp.evennement")]
    public partial class evennement
    {
        [Required]
        [StringLength(50)]
        public string titre { get; set; }

        public int id { get; set; }

        public int capacité_max { get; set; }

        [Required]
        [StringLength(20)]
        public string adresse { get; set; }

        [Required]
        [StringLength(50)]
        public string ville { get; set; }

        [Required]
        [StringLength(50)]
        public string pays { get; set; }

        public DateTime date { get; set; }

        public int nb_participant { get; set; }

        public int id_createur { get; set; }
    }
}
