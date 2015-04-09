namespace GSMInformation.Components
{
    using System;
    using System.Text;

    using GSMInformation.Enumerations;

    public class Battery
    {
        private string batteryModel;
        private int? hoursIDLE;
        private int? hoursTalk;
        private BatteryType typeOfBattery;

        #region constructors
        public Battery()
        {
            this.BatteryModel = null;
            this.HoursIDLE = null;
            this.HoursTalk = null;
        }

        public Battery(string batteryModel)
        {
            this.BatteryModel = batteryModel;
            this.HoursIDLE = null;
            this.HoursTalk = null;
        }

        public Battery(string batteryModel, int? hoursIDLE, int? hoursTalk, BatteryType typeOfBattery)
        {
            this.BatteryModel = batteryModel;
            this.HoursIDLE = hoursIDLE;
            this.HoursTalk = hoursTalk;
            this.TypeOfBattery = typeOfBattery;
        }
        #endregion

        #region properties
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("The battery model can't be empty.");
                }
                else
                {
                    this.batteryModel = value;
                }
            }
        }

        public int? HoursIDLE
        {
            get
            {
                return this.hoursIDLE;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The hours IDLE can't be negative number or zero.");
                }
                else
                {
                    this.hoursIDLE = value;
                }
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The hours for talking can't be negative number or zero.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType TypeOfBattery
        {
            get
            {
                return this.typeOfBattery;
            }

            set
            {
                this.typeOfBattery = value;
            }
        }
        #endregion

        public string PrintBatteryInfo()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Battery model: ");
            result.Append(this.BatteryModel);
            result.Append("\nHours IDLE: ");
            result.Append(this.HoursIDLE);
            result.Append("\nHours talk: ");
            result.Append(this.HoursTalk);

            return result.ToString().Trim();
        }
    }
}
