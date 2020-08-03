using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    /// <summary>
    /// 控制着每一个圆角平板的动画
    /// </summary>

    #region 字段变量
    Animation[] animation_Arch;
    #endregion

    #region 触发器方法
    public void OnTriggerEnter(Collider other)
    {
        //找到物体下的所有子物体并播放动画
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.GetComponent<Animation>().Play();
        }
    }
    #endregion

}
