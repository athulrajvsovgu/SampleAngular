namespace DatabaseAccess
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AR_Games")]
    public class Games
    {
        [Key]
        [Column("id", Order = 0)]
        public int id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public DateTime? Release { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rating { get; set; }
    }
}
