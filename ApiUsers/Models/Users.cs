namespace ApiUsers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [Key]
        public int id_Usuario { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(25)]
        public string pass { get; set; }
    }
}
