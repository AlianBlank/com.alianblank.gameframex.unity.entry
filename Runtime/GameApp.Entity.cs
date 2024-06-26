﻿#if ENABLE_GAME_FRAME_X_ENTITY
using GameFrameX.Entity.Runtime;
using GameFrameX.Runtime;

public static partial class GameApp
{
    /// <summary>
    /// 获取实体组件。
    /// </summary>
    public static EntityComponent Entity
    {
        get
        {
            if (_entity == null)
            {
                _entity = GameEntry.GetComponent<EntityComponent>();
            }

            return _entity;
        }
    }

    private static EntityComponent _entity;
}
#endif