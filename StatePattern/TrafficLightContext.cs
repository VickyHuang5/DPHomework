namespace StatePattern
{
    /// <summary>
    /// 紅綠燈
    /// </summary>
    public class TrafficLightContext
    {
        /// <summary>
        /// 目前燈號
        /// </summary>
        private ITrafficLightState State;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="state">燈號狀態</param>
        public TrafficLightContext(ITrafficLightState state)
        {
            this.State = state;
        }

        /// <summary>
        /// 切換燈號
        /// </summary>
        /// <returns>回傳切換後的燈號</returns>
        public LightStateEnum Request()
        {
            this.State = this.State.Handle();
            return this.State.GetLightState();
        }

        /// <summary>
        /// 設置燈號
        /// </summary>
        /// <param name="state">燈號狀態</param>
        /// <returns>燈號</returns>
        public LightStateEnum SetState(ITrafficLightState state)
        {
            if (!state.CheckContext(this.State))
            {
                return LightStateEnum.Null;
            }
            else
            {
                this.State = state;
                return this.State.GetLightState();
            }
        }
    }
}