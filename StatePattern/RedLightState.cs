namespace StatePattern
{
    /// <summary>
    /// 紅燈
    /// </summary>
    public class RedLightState : ITrafficLightState
    {
        /// <summary>
        /// 檢查當前狀態是否能進入目標狀態
        /// </summary>
        /// <param name="state">當前狀態</param>
        /// <returns>檢查結果boolean</returns>
        public bool CheckContext(ITrafficLightState state)
        {
            return state.GetLightState() == LightStateEnum.Yellow;
        }

        /// <summary>
        /// 取得燈號
        /// </summary>
        /// <returns>紅燈</returns>
        public LightStateEnum GetLightState()
        {
            return LightStateEnum.Red;
        }

        /// <summary>
        /// 回傳下一個燈號
        /// </summary>
        /// <returns>綠燈</returns>
        public ITrafficLightState Handle()
        {
            return new GreenLightState();
        }
    }
}