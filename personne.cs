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

        [Required]
        [StringLength(50)]
        public string mail { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        public personne(string name, string Fname, string city, string mail, string password)
        {
            this.nom = name;
            this.prenom = Fname;
            this.ville = city;
            this.mail = mail;
            this.password = password;
        }
        public personne(int id, string name, string Fname, string city, string mail, string password)
        {
            this.id = id;
            this.nom = name;
            this.prenom = Fname;
            this.ville = city;
            this.mail = mail;
            this.password = password;
        }


        public personne()
        {

        }

    }

}
