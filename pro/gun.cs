using UnityEngine;
using System.Collections;



public class gun : MonoBehaviour {

	[SerializeField]Transform hand;
	// Use this for initialization
	void Start () {
	
	}
	void Awake () {
		transform.SetParent (hand);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
