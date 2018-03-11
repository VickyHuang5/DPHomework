namespace StatePattern
{
    /// <summary>
    /// 黃燈
    /// </summary>
    public class YellowLightState : ITrafficLightState
    {
        /// <summary>
        /// 檢查當前狀態是否能進入目標狀態
        /// </summary>
        /// <param name="state">當前狀態</param>
        /// <returns>檢查結果boolean</returns>
        public bool CheckContext(ITrafficLightState state)
        {
            return state.GetLightState() == LightStateEnum.Green;
        }

        /// <summary>
        /// 取得燈號
        /// </summary>
        /// <returns>黃燈</returns>
        public LightStateEnum GetLightState()
        {
            return LightStateEnum.Yellow;
        }

        /// <summary>
        /// 回傳下一個燈號
        /// </summary>
        /// <returns>紅燈</returns>
        public ITrafficLightState Handle()
        {
            return new RedLightState();
        }
    }
}