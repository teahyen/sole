using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coupon : MonoBehaviour
{
    [SerializeField]
    public Text Coupon;
    public bool IsCoupon;
    // Start is called before the first frame update
    void Start()
    {
        IsCoupon = true;
    }
    public void OnCoupon()
    {
        // 쿠폰 번호 및 횟수 여부
        if (Coupon.text == "햄스터"&&IsCoupon ==true)
        {
            GameManager.Instance.AJump =  10;
            IsCoupon = false;
        }
        if (Coupon.text == "생쥐")
        {
            IsCoupon = true;
        }
        if (Coupon.text == "커몬커신" && IsCoupon == true)
        {
            GameManager.Instance.AJump = -10;
            IsCoupon = false;
        }
        if (Coupon.text == "로엣" && IsCoupon == true)
        {
            GameManager.Instance.AJump = 3;
            IsCoupon = false;
        }
    }
}
