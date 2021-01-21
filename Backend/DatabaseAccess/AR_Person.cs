namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AR_Person")]
    public class AR_Person
    {
        [Key]
        [Column("id", Order = 0)]
        public int id { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? Birthdate { get; set; }

        [StringLength(100)]
        public string Nickname { get; set; }
    }
}
