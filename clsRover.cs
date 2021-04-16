using System;

namespace MarsRover
{
    public class clsRover : intRover
    {
        // Declare variables and Static value of facing 
        public static  int N = 1;
    	public static  int E = 2;
    	public static  int S = 3;
    	public static  int W = 4;
      
        int x = 0;
        int y = 0;
        int facing = N;
        public clsRover()
        {
        }
        // Set start position of rover 
        public void setPosition(int x, int y, int facing)
        {
            
            this.x = x;
            this.y = y;
            this.facing = facing;
        }
        // Final Position of the rover after command
        public string displayPosition()
        {
            char dir = 'N';
            if (facing == 1)
            {
                dir = 'N';
            }
            else if (facing == 2)
            {
                dir = 'E';
            }
            else if (facing == 3)
            {
                dir = 'S';
            }
            else if (facing == 4)
            {
                dir = 'W';
            }
            return (x + " " + y + " " + dir);
            
        }
        // execute process for rover
        public void process(String commands)
        {
            for (int idx = 0; idx < commands.Length; idx++)
            {
                processCommand(commands.Substring(idx,1));
            }
        }
        // execute each command process
        public void processCommand(string command)
        {
            if (command.Equals("L"))
            {
                Leftturn();
            }
            else if (command.Equals("R"))
            {
                Rightturn();
            }
            else if (command.Equals("M"))
            {
                move();
            }
            else
            {
                throw new Exception(
                        "Inputs in Mars language, please!");
            }
        }
        // move function for rover
        public void move()
        {
            if (facing == N)
            {
                this.y++;
            }
            else if (facing == E)
            {
                this.x++;
            }
            else if (facing == S)
            {
                this.y--;
            }
            else if (facing == W)
            {
                this.x--;
            }
        }
        // Rover changing position left 90 degree from current position 
        public void Leftturn()
        {
            facing = (facing - 1) < N ? W : facing - 1;
        }
        // Rover changing position Right 90 degree from current position 
        public void Rightturn()
        {
            facing = (facing+1) > W ? N : facing + 1;
        }
      
    }
}
