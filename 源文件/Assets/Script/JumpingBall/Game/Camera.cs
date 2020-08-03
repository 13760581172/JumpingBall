using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    /// <summary>
    /// 控制摄像机Camera的功能事件
    /// </summary>

    #region 字段变量
    public Transform Target;  //获取跟随的物体Target
    #endregion

    #region unity回调函数
    void Update()
    {
        if (Mathf.Abs(Target.position.y - transform.position.y) >= 6)
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, Target.position.y + 3, transform.position.z), Time.deltaTime * 3);
    }
    #endregion

}
