using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class BoardFactory : AGame
    {

        public void buildBoard(int type) // sig ok
        {
                 throw new System.NotImplementedException();
        }
    }

    enum BoardType { DEMO, SMALL, NORMAL } 
}
