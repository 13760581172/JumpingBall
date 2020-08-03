using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    /// <summary>
    /// 控制游戏失败界面LosePanel中的功能事件
    /// </summary>

    #region 方法
    public void ShowPanel()
    {
        gameObject.SetActive(true);
    }
    #endregion

    #region 点击事件
    public void OnClickRestartButton()
    {
        //重新开始游戏
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1;
    }
    public void OnClickExitButton()
    {
        //退出至菜单界面
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }
    #endregion

}
