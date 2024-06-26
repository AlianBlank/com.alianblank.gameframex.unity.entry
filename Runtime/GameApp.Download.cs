﻿#if ENABLE_GAME_FRAME_X_DOWNLOAD
using GameFrameX.Download.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取下载组件。
    /// </summary>
    public static DownloadComponent Download
    {
        get
        {
            if (_download == null)
            {
                _download = GameEntry.GetComponent<DownloadComponent>();
            }

            return _download;
        }
    }

    private static DownloadComponent _download;
}
#endif