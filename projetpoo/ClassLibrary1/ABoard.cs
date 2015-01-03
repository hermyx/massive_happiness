using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public abstract class ABoard : IBoard
    {
        public ClassLibrary1.ATile[][] _tiles
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Collections.Generic.Dictionary<ClassLibrary1.ATile, ClassLibrary1.AUnit> _units
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ClassLibrary1.ATileFactory _tileFactory
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void moveUnit()
        {
            throw new NotImplementedException();
        }
    }
}
