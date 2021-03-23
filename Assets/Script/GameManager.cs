using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;
using System.IO;


public class GameManager : MonoSingleton<GameManager>
{ 
    //클리어 여부 2
    [SerializeField]
    public int clear;
    //클리어 여부
    [SerializeField]
    public List<bool> CS = new List<bool>(0);
    //클리어 비교
    public int currentStage;
    //추가 점프력
    [SerializeField]
    public int AJump;
    //추가 점프 횟수
    public bool IsJumping;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}


