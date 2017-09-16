using UnityEngine;
using System.Collections;

public class crosshair : MonoBehaviour {

	public Rect cr;
	public float cs = Screen.width * 0.1f;
	public Texture ct;
	// Use this for initialization
	void Start () {
		ct = Resources.Load("Texture/target") as Texture;

	}
	void OnGUI(){
		GUI.DrawTexture (cr,ct);
	}
	
	// Update is called once per frame
	void Update () {
		cr = new Rect (Screen.width / 2 - cs, Screen.height / 2 - cs, cs, cs);
	}
}
