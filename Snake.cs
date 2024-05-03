public class Snake
{
    int width;
    int height;
    public Snake(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public int Snakelength()
    {
        return (width*height);
    }
    public int[] SnakeVertical()
    {
        return (new int[Snakelength()]);
    }
    public int[] SnakeHorizontal()
    {
        return (new int[Snakelength()]);
    }
    
}