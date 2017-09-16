using UnityEngine;
using System.Collections;

public class Rayview : MonoBehaviour {
	public float weaponrange = 50f;
	public Camera tpscam;
	// Use this for initialization
	void Start () {
		tpscam.GetComponentInParent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 Lineorigin = tpscam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0));
		Debug.DrawRay (Lineorigin, tpscam.transform.forward * weaponrange, Color.green);
	}
}
