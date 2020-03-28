using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Square : IDraw, IColor
    {
        private int sideLength;
        private int locX = 0, locY = 0;
        private Rectangle rect = null;

        public void Draw(Canvas canvas)
        {
            if (this.rect != null) // if not equal to null 
                canvas.Children.Remove(this.rect); // removes the rectangle 
            else     // if it is null create a new rectangle 
                this.rect = new Rectangle();
            this.rect.Height = this.sideLength;
            this.rect.Width = this.sideLength;
            Canvas.SetTop(this.rect, this.locY);
            Canvas.SetLeft(this.rect, this.locX);
            canvas.Children.Add(this.rect);
        }

        public void SetColor(Color color)
        {
            if (this.rect != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color); // create an object 
                this.rect.Fill = brush; // property  and variable 
            }

        }
        public void SetLocation(int xCoord, int yCoord)
        {
            this.locX = xCoord;
            this.locY = yCoord;
        }
        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }
    }


}
