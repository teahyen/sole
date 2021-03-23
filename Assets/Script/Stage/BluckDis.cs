using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluckDis : MonoBehaviour
{
    [Header("건들면 사라지는 친구")]
    [SerializeField]
    public GameObject explosinPrefab;
    public int Dis;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(BlockChoi());
        }
    }

    IEnumerator BlockChoi()
    {
        yield return new WaitForSeconds(Dis);
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(Dis+5);

        GetComponent<Collider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
