using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    /// <summary>
    /// 负责游戏主界面的一跳到底介绍界面的功能事件
    /// </summary>

    #region 字段变量
    public JumpingBallPanel JumpingBallPanel;
    #endregion

    #region 事件
    public void OnClickJumpingBallButton()
    {
        JumpingBallPanel.ShowPanel();
    }

    public void OnClickExitButton()
    {
        Application.Quit();
    }
    #endregion

}
