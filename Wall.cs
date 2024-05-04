class Wall
{
    private Position position;
    private int direction;
    private int length;
    public Position Position
    {
        get { return this.position; }
        set { this.position = value; }
    }
    public int Direction
    {
        get { return this.direction; }
        set { this.direction = value; }
    }
    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }
    public Wall(Position position, int direction,int length,int[,] board)
    {
        this.Position = position;
        this.Direction = direction;
        this.Length = length;
        this.AddBoard(board);
    }
    public void AddBoard(int[,] board)
    {
        if (this.Direction == 0)
        {
            for (int i = 0; i < this.Length;i++)
            {
                board[this.Position.horizontal,this.Position.vertical +i] = 2;
            }
        }
        else{
            for (int i = 0;i < this.Length;i++)
            {
                board[this.Position.horizontal +1,this.Position.vertical] = 2;
            }
        }
    }
    public void Render()
    {
        if (this.Direction == 0)
        {
            for (int i =0;i < this.Length;i++)
            {
                Console.SetCursorPosition(this.Position.horizontal,this.Position.vertical+1);
                Console.Write("I");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        else 
        {
            for (int i = 0;i < this.Length;i++)
            {
                Console.SetCursorPosition(this.Position.horizontal+1,this.Position.vertical);
                Console.Write("H");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        
    }
}