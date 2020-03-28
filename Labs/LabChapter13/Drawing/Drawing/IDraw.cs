﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
        void SetLocation(int xCoord, int yCoord); // takes two parameters 
        void Draw(Canvas canvas); // method  named Draw with one parameter 
    }
}