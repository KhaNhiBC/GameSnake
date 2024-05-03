
using System.Runtime.InteropServices;

public class Frame
{
    int width;
    int height;
    
    public Frame(int width, int height)
    {
        this.width = width;
        this.height = height;
        
    }
    public char[,] data()
    {
        return( new char[width,height]);
    }
    public void frame(char[,] data)
    {
        
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (i == 0 || j == 0 || i == width-1 || j == height-1)
                {
                    data[i,j] ='#';
                    
                }
                else
                {data[i,j] =' ';}
                
            }
            
        }
    }
    public void show(char[,] data)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(data[i,j]);
            }
            Console.WriteLine();
        }
    }
}