﻿#if ENABLE_GAME_FRAME_X_LOCALIZATION
using GameFrameX.Localization.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取本地化组件。
    /// </summary>
    public static LocalizationComponent Localization
    {
        get
        {
            if (_localization == null)
            {
                _localization = GameEntry.GetComponent<LocalizationComponent>();
            }

            return _localization;
        }
    }

    private static LocalizationComponent _localization;
}
#endif