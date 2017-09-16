using UnityEngine;
using System.Collections;

public class getdamage : MonoBehaviour {


	public int chealth = 3;

	public void Damage(int damageAmount)
	{
		chealth -= damageAmount;
		if (chealth <= 0) {
			Destroy(transform.parent.gameObject);
		}
	}
}
