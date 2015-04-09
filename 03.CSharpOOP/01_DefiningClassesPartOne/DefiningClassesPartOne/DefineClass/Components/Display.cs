namespace GSMInformation.Components
{
    using System;
    using System.Text;

    public class Display
    {
        private float? displaySize;
        private long? numberOfColors;

        #region constructors
        public Display()
        {
            this.DisplaySize = null;
            this.NumberOfColors = null;
        }

        public Display(float? displaySize)
        {
            this.DisplaySize = displaySize;
            this.NumberOfColors = null;
        }

        public Display(float? displaySize, long? numberOfColors)
        {
            this.DisplaySize = displaySize;
            this.NumberOfColors = numberOfColors;
        }
        #endregion

        #region properties

        public float? DisplaySize
        {
            get
            {
                return this.displaySize;
            }

            set
            {
                if (value <= 0 || value == null)
                {
                    throw new ArgumentException("The display size must be bigger than 0 inches. And can't be null.");
                }
                else
                {
                    this.displaySize = value;
                }
            }
        }

        public long? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value <= 0 || value == null)
                {
                    throw new ArgumentException("The number of colors must be bigger than 0 colors. And can't be null.");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

        #endregion

        public string PrintDisplayInfo()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Display size: ");
            result.Append(this.DisplaySize + " inches");
            result.Append("\nNumber of colors: ");
            result.Append(this.NumberOfColors);

            return result.ToString().Trim();
        }
    }
}
