using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    /// <summary>
    /// 控制住弹跳小球的功能事件
    /// </summary>

    #region 字段变量
    public BallState ballState;
    public AudioClip sound;
    public float fallingSpeed = 1.0f;
    public float bounceSpeed = 1.0f;
    #endregion

    #region unity回调函数
    void Awake()
    {
        ballState = BallState.Falling;
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    void FixedUpdate()
    {
        //Falling状态时向下移动
        if (ballState == BallState.Falling)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (0.1f * fallingSpeed), transform.position.z);
        }
        //Bounce状态时执行弹跳事件
        if (ballState == BallState.Bounce)
        {
            Bounce();
        }
    }
    #endregion

    #region 方法
    private void OnCollisionEnter(Collision collision)
    {
        //发生碰撞时修改小球为反弹状态进行弹跳
        ballState = BallState.Bounce;
    }

    //弹跳事件
    public void Bounce()
    {
        float i = 0.1f * bounceSpeed;
        //执行多次，模仿弹起效果
        for (float j = 0; j <= 2; j += i)
            transform.position = new Vector3(transform.position.x, transform.position.y + i, transform.position.z);
        ballState = BallState.Falling;
        AudioManager.audioInstance.PlaySound(sound);
    }
    #endregion

}

//小球的状态
public enum BallState
{
    Bounce,       //弹起状态
    Falling,      //坠落状态
}
