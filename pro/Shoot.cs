using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	AudioSource bulaudio;

	void Start(){
		bulaudio = GetComponent<AudioSource> ();
	}
	void Fire ()	
 	{
		// shoot
		bulaudio.Play ();

	}
	void Update(){
		if (Input.GetMouseButtonDown(0)) {
			Fire();
		}
	}
}
