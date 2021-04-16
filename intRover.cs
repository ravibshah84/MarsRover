using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public interface intRover
    {
        void setPosition(int x, int y, int facing);
        string displayPosition();
        void process(String commands);
        void processCommand(string command);
        void move();
        void Leftturn();
        void Rightturn();
    }
}
