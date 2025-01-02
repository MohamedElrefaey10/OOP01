using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal struct Point
    {
        ///What You Can Write Inside The Struct Or Class
        ///1. Attributes [Fields] => Member Variable
        #region Attributes
        public int X;
        public int Y;
        #endregion

        ///2. Functions [Constructor, Getter Setter, Method]
        // Constructor special Function
        //1. Name Constructor Same Name Class Or Struct
        //2. no return

        #region Constructor
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        public Point(int Number)
        {
            X = Y = Number;
        }
        #endregion

        public override string ToString()
        {
            return $"({X})({Y})";
        }


        ///3. Properties [Full Property, Automatic Property, Indexer]
        ///4. Events


    }
}
