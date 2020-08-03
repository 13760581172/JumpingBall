using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWin : MonoBehaviour
{
    /// <summary>
    /// 控制游戏胜利的功能
    /// </summary>

    #region 字段变量
    public WinPanel winPanel;
    #endregion

    #region 方法
    public void OnCollisionEnter(Collision collision)
    {
        winPanel.ShowPanel();
        Arch.arch.canPlayState = CanPlayState.dontPlay;
        Time.timeScale = 0;
        float time = PlayerPrefs.GetFloat("time", 0);
        float bestTime = PlayerPrefs.GetFloat("bestTime", 100);
        if (time < bestTime)
            PlayerPrefs.SetFloat("bestTime", time);
    }
    #endregion

}
