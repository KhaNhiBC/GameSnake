public class Begin
{
    static int width = 25;
    static int height = 25;  
    static Begin()
    {
        Frame frame = new Frame(width,height);
        char[,] data1 = frame.data();
        frame.frame(data1);
        Snake snake = new Snake(width,height);
        snake.Snakelength();
        int[] SnakeHorizontal = snake.SnakeHorizontal();
        int[] SnakeVertical = snake.SnakeVertical();
        SnakeHorizontal[0] = 4;
        SnakeVertical[0] = 5;
        data1[SnakeHorizontal[0],SnakeVertical[0]] = 'O';
        Bait bait= new Bait(width,height);
        int baitHorizontal = bait.BaitHorizontal();
        int baitVertical = bait.BaitVertical();
        if (SnakeHorizontal[0] == baitHorizontal && SnakeVertical[0] == baitVertical)
        {
            baitHorizontal = bait.BaitHorizontal();
            baitVertical = bait.BaitVertical();
        }
        data1[baitHorizontal,baitVertical] = '*';
        frame.show(data1);
    }
    
}