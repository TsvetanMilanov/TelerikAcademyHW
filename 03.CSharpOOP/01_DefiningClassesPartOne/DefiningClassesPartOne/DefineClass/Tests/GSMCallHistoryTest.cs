namespace GSMInformation.Tests
{
    using System;
    using System.Collections.Generic;

    using GSMInformation.Components;
    using GSMInformation.Enumerations;
    using GSMInformation.Functions;

    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            /// This method is called in  the Main method in GSMTest class.

            Battery batteryType = new Battery("BST-41", 425, 8, BatteryType.LiIon);
            Display displayType = new Display(4.0f, 16000000);

            GSM x10 = new GSM();

            /// Init the GSM.
            x10.Model = "X10";
            x10.Manufacturer = "Sony Ericsson";
            x10.Price = 600;
            x10.Owner = "Ceco";
            x10.BatteryType = batteryType;
            x10.DisplayType = displayType;

            /// Add calls.
            x10.AddCall(new Call(new DateTime(2015, 3, 11, 23, 9, 56), "+359883123456", 180));

            x10.AddCall(new Call(new DateTime(2015, 3, 10, 9, 2, 53), "+359883123457", 240));

            x10.AddCall(new Call(new DateTime(2015, 3, 9, 3, 34, 22), "+359883123458", 320));

            DisplayCallInformation(x10.CallHstory);

            Console.WriteLine("Price before removing the longest call:");
            CalculatePrice(x10);

            RemoveLongestCall(x10);

            Console.WriteLine("Price after removing the longest call:");
            CalculatePrice(x10);

            x10.ClearCallHistory();

            DisplayCallInformation(x10.CallHstory);
        }

        private static void RemoveLongestCall(GSM x10)
        {
            List<Call> allCalls = x10.CallHstory;

            int longestCallDuration = int.MinValue;
            int index = 0;

            for (int i = 0; i < allCalls.Count; i++)
            {
                int currentCall = allCalls[i].Duration;

                if (currentCall >= longestCallDuration)
                {
                    longestCallDuration = currentCall;
                    index = i;
                }
            }

            x10.RemoveCall(index);
        }

        private static void CalculatePrice(GSM gsm)
        {
            decimal sum = 0;
            float minutePrice = 0.37f;

            sum = gsm.CalculateCallPrice(minutePrice);

            Console.WriteLine("Total price for all calls in the call history: {0}$", sum);
            Console.WriteLine();
        }

        private static void DisplayCallInformation(List<Call> allCalls)
        {
            Console.WriteLine("Call history:\n");

            if (allCalls.Count > 0)
            {
                for (int i = 0; i < allCalls.Count; i++)
                {
                    Call currentCall = allCalls[i];

                    Console.WriteLine("Call #{0}:", i + 1);
                    Console.WriteLine("Date: {0}", currentCall.Date);
                    Console.WriteLine("Time: {0} h", currentCall.Time);
                    Console.WriteLine("Duration: {0} seconds", currentCall.Duration);
                    Console.WriteLine("To: {0}", currentCall.DialedNumber);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The call history is empty.");
                Console.WriteLine();
            }
        }
    }
}
