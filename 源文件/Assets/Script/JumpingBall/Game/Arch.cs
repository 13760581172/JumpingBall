using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arch : MonoBehaviour
{
    /// <summary>
    /// 控制所有圆角平板的功能
    /// </summary>

    #region 字段变量
    public static Arch arch;
    public int rotationSpeed;           //旋转速度
    public MeshRenderer centerMesh;     //轴心（直接修改rotation无法绕固定轴心旋转，设置中间的柱体为轴心进行旋转即可）
    public CanPlayState canPlayState = CanPlayState.canPlay;
    #endregion

    #region unity回调函数
    private void Awake()
    {
        arch = this;
    }

    void Update()
    {
        if (canPlayState == CanPlayState.canPlay)
        {
            //鼠标点击时执行
            if (Input.GetMouseButton(0))
            {
                /*
                    RotateAround：一个物体围绕另外一个物体旋转
                    centerMesh.bounds.center为轴心
                    -Input.GetAxis("Mouse X")为鼠标x轴移动的距离，但unity方向相反，需要加-逆转方向
                    rotationSpeed为旋转速度，可在Inspector定义
                */
                transform.RotateAround(centerMesh.bounds.center, new Vector3(0, 1, 0), -Input.GetAxis("Mouse X") * rotationSpeed);
            }
        }
    }
    #endregion

}

//能否拖动Arch的指标
public enum CanPlayState
{
    canPlay,
    dontPlay,
}
