namespace GSMInformation
{
    using System.Collections.Generic;
    using System.Text;

    using GSMInformation.Components;
    using GSMInformation.Functions;

    public class GSM
    {
        private static GSM testIPhone4S = new GSM("4S", "IPhone", 300, "Pesho", new Battery("BST-41", 168, 5, Enumerations.BatteryType.LiPolymer), new Display(3.5f, 16000000));

        private string model;
        private string manufacturer;
        private float? price;
        private string owner;
        private Battery batteryType;
        private Display displayType;
        private List<Call> allCalls;

        public GSM()
        {
            this.Model = null;
            this.Manufacturer = null;
            this.Price = null;
            this.Owner = null;
            this.BatteryType = null;
            this.DisplayType = null;
            this.allCalls = new List<Call>();
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.BatteryType = null;
            this.DisplayType = null;
            this.allCalls = new List<Call>();
        }

        public GSM(string model, string manufacturer, float? price, string owner, Battery batteryType, Display displayType)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatteryType = batteryType;
            this.DisplayType = displayType;
            this.allCalls = new List<Call>();
        }

        #region properties

        public static string IPhone4S
        {
            get
            {
                return testIPhone4S.ToString();
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                this.manufacturer = value;
            }
        }

        public float? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        /// Sets the battery characteristics.
        public Battery BatteryType
        {
            set
            {
                this.batteryType = value;
            }
        }

        /// Prints the battery information.
        public string BatteryInfo
        {
            get
            {
                return this.batteryType.PrintBatteryInfo();
            }
        }

        /// Sets the display characteristics.
        public Display DisplayType
        {
            set
            {
                this.displayType = value;
            }
        }

        /// Prints the display characteristics.
        public string DisplayInfo
        {
            get
            {
                return this.displayType.PrintDisplayInfo();
            }
        }

        public List<Call> CallHstory
        {
            get
            {
                return this.allCalls;
            }
        }

        #endregion

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("GSM information:");
            result.Append("\nModel: ");
            result.Append(this.Model);
            result.Append("\nManufacturer: ");
            result.Append(this.Manufacturer);
            result.Append("\nPrice: ");
            result.Append(this.Price + "$");
            result.Append("\nOwner: ");
            result.Append(this.Owner);
            result.Append("\n\nBattery characteristics:\n");
            result.Append(this.BatteryInfo);
            result.Append("\n\nDisplay characteristics:\n");
            result.Append(this.DisplayInfo);

            return result.ToString();
        }

        public void AddCall(Call callToAdd)
        {
            this.allCalls.Add(callToAdd);
        }

        public void RemoveCall(int index)
        {
            this.allCalls.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.allCalls.Clear();
        }

        public decimal CalculateCallPrice(float pricePerMinute)
        {
            decimal result = 0;

            foreach (var call in this.allCalls)
            {
                result = result + (decimal)((call.Duration / 60) * pricePerMinute);
            }

            return result;
        }
    }
}
