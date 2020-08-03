using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    /// <summary>
    /// 控制游戏界面GamePanel中的功能事件
    /// </summary>

    #region 字段变量
    public SettingPanel settingPanel;
    public AudioClip music;
    public Text timeText;
    public Text bestTimeText;
    public float time = 0;
    #endregion

    #region unity回调函数
    //游戏开始时设置分数为0,并播放背景音乐
    void Start()
    {
        AudioManager.audioInstance.PlayMusic(music);
        float bestTime = PlayerPrefs.GetFloat("bestTime", 100);
        if (bestTime == 100)
            this.bestTimeText.text = "无";
        else
            this.bestTimeText.text = string.Format("{0:F}", bestTime) + "s";
    }

    //更新分数
    void Update()
    {
        time += Time.deltaTime;
        string timeText = string.Format("{0:F}", time) + "s";
        PlayerPrefs.SetFloat("time", time);
        this.timeText.text = timeText;
    }
    #endregion

    #region 点击事件
    public void OnClickExitButton()
    {
        //退出至菜单界面
        SceneManager.LoadSceneAsync(0);
    }

    public void OnClickSettingButton()
    {
        //打开设置界面
        settingPanel.ShowPanel();
    }
    #endregion

}
