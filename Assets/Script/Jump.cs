using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //바닥에 닿으면
        if (collision.gameObject.CompareTag("Ground"))
        {
            //점프가 가능한 상태로 만듦
            GameManager.Instance.IsJumping = true;
        }
        else
        {
            //점프가 가능한 상태로 만듦
            GameManager.Instance.IsJumping = false;
        }
    }
}
