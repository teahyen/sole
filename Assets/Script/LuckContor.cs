using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LuckContor : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> strList = new List<GameObject>(0);

    public void Start()
    {
        for (int i = 0; i < GameManager.Instance.CS.Count; i++)
        {
            if (GameManager.Instance.CS[i])
            {
                strList[i].SetActive(false);
            }
        }
    }
}

