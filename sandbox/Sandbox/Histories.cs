public abstract class Histories
{
    public abstract void History();
}

 public class MagazineLatestNews : Histories
 {
     public override void History()
     {
        Console.WriteLine("Elder Patrick Kearon is the newest member of the Quorum of the Twelve Apostles of The Church of Jesus Christ of Latter-day Saints.");
     }
 }

 public class LdsLatestNews : Histories
{
    public override void History()
    {
        Console.WriteLine("This focus will fuel sustained growth, payment innovation, and expansion across the globe.");
    }
}