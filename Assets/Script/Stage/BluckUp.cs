using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluckUp : MonoBehaviour
{
    [SerializeField]
    Vector3 pos;
    [SerializeField]
    float delta = 4.0f;
    [SerializeField]
    float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
