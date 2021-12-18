using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    class BubbleSorting : ISortings
    {
        private int[] tomb_;
        private Graphics grafika_;
        private int maximum_;
        private bool rendezett = false;
        //Színek
        Brush Khaki = new System.Drawing.SolidBrush(System.Drawing.Color.Khaki);
        Brush Black = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        public void DoSorting(int[] tomb, Graphics grafika, int maximum)
        {
            tomb_ = tomb;
            grafika_ = grafika;
            maximum_ = maximum;

            while (!rendezett)
            {
                for (int i = 0; i < tomb_.Count()-1; i++)
                {
                    if (tomb_[i] > tomb_[i+1])
                    {
                        int temp = tomb_[i];
                        tomb_[i] = tomb_[i + 1];
                        tomb_[i + 1] = temp;

                        grafika_.FillRectangle(Black, i, 0, 1, maximum_);
                        grafika_.FillRectangle(Black, i+1, 0, 1, maximum_);

                        grafika_.FillRectangle(Khaki, i, maximum_ - tomb_[i], 1, maximum_);
                        grafika_.FillRectangle(Khaki, i+1, maximum_ - tomb_[i+1], 1, maximum_);
                    }
                    rendezett = RendezettTomb();
                }
            }
        }
        private bool RendezettTomb()
        {
            for (int i = 0; i < tomb_.Count()-1; i++)
            {
                if (tomb_[i] > tomb_[i+1]) 
                    return false;
            }
            return true;
        }
    }
}
