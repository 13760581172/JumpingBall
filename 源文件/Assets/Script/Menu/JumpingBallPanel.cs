using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpingBallPanel : MonoBehaviour
{
    /// <summary>
    /// 负责游戏主界面的一跳到底介绍界面的功能事件
    /// </summary>

    #region 方法
    public void ShowPanel()
    {
        gameObject.SetActive(true);
    }
    #endregion

    #region 事件
    public void OnClickCloseButton()
    {
        gameObject.SetActive(false);
    }
    public void OnClickGameButton()
    {
        SceneManager.LoadScene(1);
    }
    #endregion

}
