﻿#if ENABLE_GAME_FRAME_X_SOUND
using GameFrameX.Runtime;
using GameFrameX.Sound.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取声音组件。
    /// </summary>
    public static SoundComponent Sound
    {
        get
        {
            if (_sound == null)
            {
                _sound = GameEntry.GetComponent<SoundComponent>();
            }

            return _sound;
        }
    }

    private static SoundComponent _sound;
}
#endif