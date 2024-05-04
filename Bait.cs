
class Bait
{
    private Position position;
    private Random Rand;
    private bool eaten;
    
    public int BaitHorizontal(int width)
    {
        return (Rand.Next(1, width-1));
    }
    public int BaitVertical(int height)
    {
        return (Rand.Next(1, height-1));
    }
    public bool Eaten
    {
        get { return eaten; }
        set { eaten = value; }
    }
    public Position Position
    {
        get { return position; }
        set { position = value; }
    }
    public Bait(Position position)
    {
        this.position = position;
        this.eaten = false;
        this.Rand = new Random();
    }
    public void Spawn(int[,] board)
    {
        
        this.position.horizontal = Rand.Next(1,39);
        this.position.vertical = Rand.Next(1,39);
        while(board[this.Position.horizontal,this.Position.vertical] != 0)
        {
            this.position.horizontal = Rand.Next(1,39);
            this.position.vertical = Rand.Next(1,39);
        }
    } 
    public void Render()
    {
        Console.SetCursorPosition(this.position.horizontal, this.position.vertical);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("*");
        Console.ForegroundColor= ConsoleColor.Yellow;
    }
    public void Update(int[,] board)
    {
        if (this.Eaten)
        {
            this.Eaten = false;
            this.Spawn(board);
        }
    }
}