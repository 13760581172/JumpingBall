using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPanel : MonoBehaviour
{
    /// <summary>
    /// 控制设置界面SettingPanel中的功能事件
    /// </summary>

    #region 字段变量

    public Slider musicSlider;
    public Slider soundSlider;
    #endregion

    #region 方法
    //音乐音量大小
    public void OnMusicSlider(float musicValue)
    {
        //修改音乐音量大小
        AudioManager.audioInstance.OnMusicVolumeChange(musicValue);
        //将数值保存在硬盘中
        PlayerPrefs.SetFloat("musicValue", musicValue);
    }

    //音效音量大小
    public void OnSoundSlider(float soundValue)
    {
        //修改音乐音量大小
        AudioManager.audioInstance.OnSoundVolumeChange(soundValue);
        //将数值保存在硬盘中
        PlayerPrefs.SetFloat("soundValue", soundValue);
    }
    public void ShowPanel()
    {
        gameObject.SetActive(true);
        musicSlider.value = PlayerPrefs.GetFloat("musicValue", 1.0f);
        soundSlider.value = PlayerPrefs.GetFloat("soundValue", 0.2f);
        Arch.arch.canPlayState = CanPlayState.dontPlay;
        Time.timeScale = 0;
    }
    #endregion

    #region 点击事件
    public void OnClickCloseButoon()
    {
        gameObject.SetActive(false);
        Arch.arch.canPlayState = CanPlayState.canPlay;
        Time.timeScale = 1;
    }
    #endregion
}
