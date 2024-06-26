﻿#if ENABLE_GAME_FRAME_X_EVENT
using GameFrameX.Event.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取事件组件。
    /// </summary>
    public static EventComponent Event
    {
        get
        {
            if (_event == null)
            {
                _event = GameEntry.GetComponent<EventComponent>();
            }

            return _event;
        }
    }

    private static EventComponent _event;
}
#endif