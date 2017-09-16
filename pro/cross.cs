using UnityEngine;
using System.Collections;

public class cross : MonoBehaviour {

	[SerializeField] Texture2D image;
	public int size;
	public float minangle;
	public float maxangle;
	float screenp;
	float lookheight;
	public Camera camera;

/*	public void LookHeight(float value){
		lookheight += value;

		if (lookheight < maxangle || lookheight > minangle) {
			lookheight -= value;
		}
	}*/
	// Use this for initialization
	void OnGUI () {
		Vector3 screenposition = camera.WorldToScreenPoint (transform.position);
		//screenp = Screen.height - screenposition.y;
		GUI.DrawTexture(new Rect(screenposition.x,screenposition.y,size,size), image);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
