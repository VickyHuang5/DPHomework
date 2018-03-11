using System;

namespace StatePattern
{
    /// <summary>
    /// 主程式
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("請輸入開始燈號(Green,Yellow or Red)及切換次數，如：Green,10");
            string[] input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            LightStateEnum lightState = (LightStateEnum)Enum.Parse(typeof(LightStateEnum), input[0]);
            TrafficLightContext trafficLightContext = null;
            string result = string.Empty;
            if (lightState.Equals(LightStateEnum.Green))
            {
                trafficLightContext = new TrafficLightContext(new GreenLightState());
                lightState = trafficLightContext.SetState(new GreenLightState());
            }

            if (lightState.Equals(LightStateEnum.Yellow))
            {
                trafficLightContext = new TrafficLightContext(new YellowLightState());
                lightState = trafficLightContext.SetState(new YellowLightState());
            }

            if (lightState.Equals(LightStateEnum.Red))
            {
                trafficLightContext = new TrafficLightContext(new RedLightState());
                lightState = trafficLightContext.SetState(new RedLightState());
            }

            for (int i = 0; i < Convert.ToInt32(input[1]); i++)
            {
                result = Enum.GetName(typeof(LightStateEnum), trafficLightContext.Request());
                Console.WriteLine($"目前燈號:{result}");
            }

            Console.ReadKey();
        }
    }
}