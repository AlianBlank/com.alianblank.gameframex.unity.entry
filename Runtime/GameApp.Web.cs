﻿#if ENABLE_GAME_FRAME_X_WEB
using GameFrameX.Runtime;
using GameFrameX.Web.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取Web组件。
    /// </summary>
    public static WebComponent Web
    {
        get
        {
            if (_web == null)
            {
                _web = GameEntry.GetComponent<WebComponent>();
            }

            return _web;
        }
    }

    private static WebComponent _web;
}
#endif