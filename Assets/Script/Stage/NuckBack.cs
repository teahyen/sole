using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuckBack : MonoBehaviour
{

	[SerializeField]
	float Knock = 10f;
	public GameObject Player;

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject == Player)
		{
			if (transform.position.x < Player.transform.position.x)
			{
				Player.transform.Translate(Knock, 1, 0);
			}
			else
			{
				Player.transform.Translate(-Knock, 1, 0);
			}
		}
	}
}
