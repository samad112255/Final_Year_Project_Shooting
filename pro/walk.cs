using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {

	public float walks = 2;
	public float run = 6;
	public float smoothtime = 0.2f;
	public Transform camerat;
	float turnvelocity;
	float speedr = 5f;
	public bool cursorlock;


	// Use this for initialization
	void Start () {
		if (cursorlock) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
//		camerat = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
	Vector2 v2 = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
	Vector2 inputdir = v2.normalized;
	 float rotatex = Input.GetAxis("Mouse X");


	if (inputdir != Vector2.zero) {
			float targetrot = Mathf.Atan2 (inputdir.x, inputdir.y) * Mathf.Rad2Deg + camerat.eulerAngles.y;
			transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y,targetrot,ref turnvelocity,smoothtime);

		}
		bool running = Input.GetKey(KeyCode.LeftShift);
		float speed = ((running) ? run : walks) * inputdir.magnitude;
		                            
		transform.Translate (transform.forward * speed * Time.deltaTime, Space.World);
		transform.Rotate (0, rotatex * speedr, 0);

	}
}
