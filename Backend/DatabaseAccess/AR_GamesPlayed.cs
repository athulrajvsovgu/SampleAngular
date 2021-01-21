namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_GamesPlayed
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Game { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rating { get; set; }

        public DateTime? Release { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Firstname { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Nickname { get; set; }
    }
}
