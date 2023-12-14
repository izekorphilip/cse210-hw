//Similarly, in the RecentUpdates class file, inherit from 
//the Histories class and implement the abstract methods.


public class RecentUpdates : Histories
{
    public override void History()
    {
       Console.WriteLine("Channels TV provides trusted Nigeria and African news with Comprehensive and up-to-date news coverage");
    }
}

 public class BBCNews : Histories
 {
     public override void History()
     {
        Console.WriteLine("The BBC has announced its intention to bring BBC News in the UK and World News together into a single TV channel called BBC News. ");
     }
 }