class Begin
{
    private Snake snake;
    private Bait bait;
    private List<Wall> walls;
    private int[,] board;
    private bool run;
    Random rand = new Random();
    public Begin()
    {
        run = true;
        snake = new Snake();
        snake.Init();
        board = new int[40,40];
        bait = new Bait(new Position(rand.Next(1,39),rand.Next(1,39)));
        walls = [
            new Wall(new Position(0,0),0,this.board.GetLength(1),this.board),
            new Wall(new Position(39,0),0,this.board.GetLength(1),this.board),
            new Wall(new Position(0,0),1,this.board.GetLength(0),this.board),
            new Wall(new Position(0,39),1,this.board.GetLength(0),this.board),
        ];
    }
    public void Run()
    {
        while (run)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if ((key == ConsoleKey.W || key == ConsoleKey.UpArrow) && this.snake.SnakeDirection[0].vertical == 0)
                {
                    this.snake.Newdir = new Position(0,-1);
                }
                else if ((key == ConsoleKey.S || key == ConsoleKey.DownArrow) && this.snake.SnakeDirection[0].vertical == 0)
                {
                    this.snake.Newdir = new Position(0,1);
                }
                else if ((key == ConsoleKey.A || key == ConsoleKey.LeftArrow) && this.snake.SnakeDirection[0].horizontal == 0)
                {
                    this.snake.Newdir = new Position(-1,0);
                }
                else if ((key == ConsoleKey.D || key == ConsoleKey.RightArrow) && this.snake.SnakeDirection[0].horizontal == 0)
                {
                    this.snake.Newdir = new Position(1,0);
                }
            }
            Console.Clear();
            this.bait.Update(this.board);
            this.snake.Update(this.board,this.bait,ref this.run);
            this.bait.Render();
            this.snake.Render();
            foreach (Wall wall in walls)
            {
                wall.Render();
            }
            
            Thread.Sleep(120-this.snake.Length-2);
            this.snake.Newdir = null;
        }
    }

    

    
    
}