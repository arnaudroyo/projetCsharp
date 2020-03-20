namespace CsharpB2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("projetcsharp.inscris")]
    public partial class inscri
    {
        public int id { get; set; }

        public int id_personne { get; set; }

        public int id_evennement { get; set; }
    }
}
