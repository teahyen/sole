using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    SpringJoint rend;
    public Rigidbody2D rigid;
    [SerializeField]
    public int JumpPower = 10;
    private float speed = 10f;
    bool a, b;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        //}
        if(a)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (b)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }
    public void LiftUp()
    {
        a = false;
    }
    public void LiftDown()
    {
        a = true;
    }
    public void RightUp()
    {
        b = false;
    }
    public void RightDown()
    {
        b = true;
    }
    public void Jump()
    {
        //바닥에 있으면 점프를 실행
        if (GameManager.Instance.IsJumping ==true)
        {
            rigid.AddForce(Vector2.up * (JumpPower+GameManager.Instance.AJump), ForceMode2D.Impulse);
            GameManager.Instance.IsJumping =false;
        }
    }
}
