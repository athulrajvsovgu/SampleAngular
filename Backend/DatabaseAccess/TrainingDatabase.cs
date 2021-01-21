namespace DatabaseAccess
{
    using System.Data.Entity;

    public class TrainingDatabase : DbContext
    {
        public TrainingDatabase()
            : base("name=TrainingDatabase")
        {
        }

        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<AR_Person> AR_Person { get; set; }
        public virtual DbSet<AR_PersonRelatedGames> AR_PersonRelatedGames { get; set; }
        public virtual DbSet<AR_GamesPlayed> AR_GamesPlayed { get; set; }
    }
}
