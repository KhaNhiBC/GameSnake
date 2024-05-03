
public class Bait
{
    int width;
    int height;
    Random Rang = new Random();
    public Bait(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public int BaitHorizontal()
    {
        return (Rang.Next(1, width-1));
    }
    public int BaitVertical()
    {
        return (Rang.Next(1, height-1));
    }
    
}