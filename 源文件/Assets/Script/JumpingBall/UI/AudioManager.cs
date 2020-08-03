using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    /// <summary>
    /// 控制游戏中Audio音效的功能事件
    /// </summary>

    #region 字段变量
    public static AudioManager audioInstance;
    public AudioSource Music, Sound;
    #endregion

    #region unity回调函数
    void Awake()
    {
        audioInstance = this;
        //获取两个音乐的AudioSource组件
        Music = transform.Find("Music").GetComponent<AudioSource>();
        Sound = transform.Find("Sound").GetComponent<AudioSource>();

        //获取到保存的声音大小
        Music.volume = PlayerPrefs.GetFloat("musicValue", 1.0f);
        Sound.volume = PlayerPrefs.GetFloat("soundValue", 0.2f);
    }
    #endregion

    #region 方法
    //播放音乐
    public void PlayMusic(AudioClip audioClip)
    {
        Music.clip = audioClip;
        Music.loop = true;        //循环播放
        Music.Play();             //播放音乐
    }

    //播放音效
    public void PlaySound(AudioClip audioClip)
    {
        Sound.PlayOneShot(audioClip);  //播放一小段音效
    }

    //修改音乐音量大小
    public void OnMusicVolumeChange(float value)
    {
        Music.volume = value;
    }

    //修改音效音量大小
    public void OnSoundVolumeChange(float value)
    {
        Sound.volume = value;
    }
    #endregion

}
