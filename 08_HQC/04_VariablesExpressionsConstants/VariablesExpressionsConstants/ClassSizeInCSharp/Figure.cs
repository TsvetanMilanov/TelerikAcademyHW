namespace Figures
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double inputWidth, double inputHeight)
        {
            this.Width = inputWidth;
            this.Height = inputHeight;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Figure Rotate(Figure figure, double angleOfFigureRotation)
        {
            double rotatedWidth = figure.CalculateRotationOfWidth(angleOfFigureRotation);

            double rotatedHeight = figure.CalculateRotationOfHeight(angleOfFigureRotation);

            Figure rotatedFigure = new Figure(rotatedWidth, rotatedHeight);

            return rotatedFigure;
        }

        private double CalculateRotationOfWidth(double angleOfFigureRotation)
        {
            double sinusOfAngleOfRotation = Math.Abs(Math.Sin(angleOfFigureRotation));

            double cosinusOfAngleOfRotation = Math.Abs(Math.Cos(angleOfFigureRotation));

            double calculatedRotationOfWidth = (cosinusOfAngleOfRotation * this.Width) + (sinusOfAngleOfRotation * this.Height);

            return calculatedRotationOfWidth;
        }

        private double CalculateRotationOfHeight(double angleOfFigureRotation)
        {
            double sinusOfAngleOfRotation = Math.Abs(Math.Sin(angleOfFigureRotation));

            double cosinusOfAngleOfRotation = Math.Abs(Math.Cos(angleOfFigureRotation));

            double calculatedRotationOfHeight = (sinusOfAngleOfRotation * this.Width) + (cosinusOfAngleOfRotation * this.Height);

            return calculatedRotationOfHeight;
        }
    }
}
