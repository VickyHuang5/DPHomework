namespace StatePattern
{
    /// <summary>
    /// 紅綠燈狀態介面
    /// </summary>
    public interface ITrafficLightState
    {
        /// <summary>
        /// 燈號處理
        /// </summary>
        /// <returns>紅綠燈狀態</returns>
        ITrafficLightState Handle();

        /// <summary>
        /// 取得目前燈號狀態
        /// </summary>
        /// <returns>燈號狀態</returns>
        LightStateEnum GetLightState();

        /// <summary>
        /// 檢查當前狀態是否能進入目標狀態
        /// </summary>
        /// <param name="state">當前狀態</param>
        /// <returns>檢查結果boolean</returns>
        bool CheckContext(ITrafficLightState state);
    }
}