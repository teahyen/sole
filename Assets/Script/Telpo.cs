using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telpo : MonoBehaviour
{
    [Header("텔레포트")]
    [SerializeField]
    public Transform Target;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = Target.position;
        }
    }
}
