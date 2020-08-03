using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLose : MonoBehaviour
{
    /// <summary>
    /// 控制游戏失败的功能
    /// </summary>

    #region 字段变量
    public LosePanel losePanel;
    #endregion

    #region 方法
    public void OnCollisionEnter(Collision collision)
    {
        losePanel.ShowPanel();
        Arch.arch.canPlayState = CanPlayState.dontPlay;
        Time.timeScale = 0;
    }
    #endregion

}
