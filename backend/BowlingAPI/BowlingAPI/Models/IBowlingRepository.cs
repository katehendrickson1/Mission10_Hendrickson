namespace BowlingAPI.Models
{
    //public interface IBowlingRepository
    //{
    //    IEnumerable<Bowler> Bowlers { get; }
    //}
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> GetBowlersForMarlinsAndSharks();
    }
}

