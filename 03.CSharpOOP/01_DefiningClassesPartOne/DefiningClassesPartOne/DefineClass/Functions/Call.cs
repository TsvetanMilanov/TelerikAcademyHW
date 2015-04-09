namespace GSMInformation.Functions
{
    using System;
    using System.Text;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedPhoneNumber;
        private int duration;

        public Call()
        {
            this.date = DateTime.Now;
            this.time = DateTime.Now;
            this.dialedPhoneNumber = string.Empty;
            this.duration = 0;
        }

        public Call(DateTime date, string dialedPhoneNumber, int duration)
        {
            this.SetDate = date;
            this.SetTime = date;
            this.DialedNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        #region properties

        /// Get date.
        public string Date
        {
            get
            {
                return string.Format("{0:00}.{1:00}.{2:00}", this.date.Day, this.date.Month, this.date.Year);
            }
        }

        /// Set date.
        public DateTime SetDate
        {
            set
            {
                this.date = value;
            }
        }

        /// Get the time.
        public string Time
        {
            get
            {
                return this.GetTime();
            }
        }

        /// Set time.
        public DateTime SetTime
        {
            set
            {
                this.time = new DateTime(1, 1, 1, value.Hour, value.Minute, value.Second);
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }

            set
            {
                this.dialedPhoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                this.duration = value;
            }
        }

        #endregion

        private string GetTime()
        {
            StringBuilder result = new StringBuilder();

            string timeFormatString = "{0:00}";

            result.Append(string.Format(timeFormatString, this.time.Hour) + ":");
            result.Append(string.Format(timeFormatString, this.time.Minute) + ":");
            result.Append(string.Format(timeFormatString, this.time.Second));

            return result.ToString();
        }
    }
}
