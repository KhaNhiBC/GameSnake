using System.Net.Http.Headers;
using System.Xml.Linq;
class Snake
{
    
    private List<Position> body;
    private List<Position> direction;
    public int length;
    private Position? newdir;
    public List<Position> SnakeBody
    {
        get { return body; }
        set { body = value; }
    }
    public List<Position> SnakeDirection
    {
        get { return direction; }
        set { direction = value; }
    }
    public int Length
    {
        get { return length;}
        set { length = value; }
    }
    public Position? Newdir
    {
        get { return newdir;}
        set { newdir = value; }
    }
    public Snake()
    {
        this.body = new List<Position>();
        this.direction = new List<Position>();
        this.length = 2;
    }
    public void Init()
    {
        this.SnakeBody.Add(new Position(7,5));
        this.SnakeBody.Add(new Position(7,6));
        this.SnakeBody.Add(new Position(7,7));
        this.SnakeDirection.Add(new Position(0,1));
        this.SnakeDirection.Add(new Position(0,1));
        this.SnakeDirection.Add(new Position(0,1));
    }
    public void Render()
    {
        foreach (var item in this.body)
        {
            Console.SetCursorPosition(item.vertical,item.horizontal);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("O");
            Console.ForegroundColor= ConsoleColor.Green;
        }
    }
    public void SnakeMove(int[,] board,ref bool run)
    {
        for (int i = 0;i < this.SnakeBody.Count; i++)
        {
            var bodyinit = this.SnakeBody[i];
            bodyinit.vertical += this.SnakeDirection[i].vertical;
            bodyinit.horizontal += this.SnakeDirection[i].horizontal;
            this.SnakeBody[i] = bodyinit;
            if (i == 0)
            {
                if (board[this.SnakeBody[i].vertical,this.SnakeBody[i].horizontal] == 2)
                {
                    run = false;
                }
            }
            board[this.SnakeBody[i].vertical,this.SnakeBody[i].horizontal] = 1;
        }
    }
    public void ChangeDirBodyint(Position? dir)
    {
        for (int i = (this.SnakeBody.Count)- 1;i > 0;i--)
        {
            this.SnakeDirection[i] = this.SnakeDirection[i-1];
        }
        if (dir != null)
        {
            this.SnakeDirection[0] = new Position(dir.Value.vertical, dir.Value.horizontal);
        }

    }
    public void Eat(Bait bait)
    {
        if (bait.Position == this.SnakeBody[0])
        {
            bait.Eaten = true;
            this.SnakeBody.Add(new Position(this.SnakeBody[this.SnakeBody.Count-1].horizontal - this.SnakeDirection[this.SnakeDirection.Count-1].horizontal,
            this.SnakeBody[this.SnakeBody.Count-1].vertical - this.SnakeDirection[this.SnakeDirection.Count-1].vertical));
            this.SnakeDirection.Add(new Position(this.SnakeDirection[this.SnakeDirection.Count - 1].horizontal,
            this.SnakeDirection[this.SnakeDirection.Count-1].vertical));
        }   
    }
    public void Update(int[,] board, Bait bait, ref bool run)
    {
        this.ChangeDirBodyint(this.Newdir);
        this.SnakeMove(board,ref run);
        this.Eat(bait);
        this.Length = this.SnakeBody.Count;
    }
}