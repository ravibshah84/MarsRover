using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class clsSelectRoverType : AbsRoverType
    {

        public override intRover getrovertype(string strrovertype)
        {
            if (strrovertype == "marsrover")
            {

                return new clsRover();
            }
            else
                return null;
            
        }

    }
}
