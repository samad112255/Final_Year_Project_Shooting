using UnityEngine;
using System.Collections;

public class walking_ayesha : MonoBehaviour {


	static Animator ani;
	public Transform lookat;
	public float speed = 2.0f;
	public float rspeed = 250.0f;
	public float currentx = 0.0f;
	public float currenty = 0.0f;
	public float distance = 5.0f;
	public float minlimit = 0f;
	public float maxlimit = 0f;
	public GameObject camera;
	


	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
	/*	Vector2 v2 = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		Vector2 inputdir = v2.normalized;
		if (inputdir != Vector2.zero) {
			transform.eulerAngles = Vector3.up * Mathf.Atan2 (inputdir.x, inputdir.y) * Mathf.Rad2Deg;
		}
		transform.Translate (transform.forward * 2 * Time.deltaTime, Space.World);*/
	
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotationx = Input.GetAxis ("Horizontal") * rspeed;
	//	float rotationy = Input.GetAxis ("Mouse Y") * rspeed;


		if ((translation != 0)) {


			if (Input.GetKey (KeyCode.LeftShift)) {
		//		ani.SetBool ("Iswalking", false);
				ani.SetBool ("isrun", true);
					
				if(Input.GetKey(KeyCode.Mouse1)){
					ani.SetBool("kick",true);
				}else{
					ani.SetBool("kick",false);
					if( Input.GetKey(KeyCode.Mouse0)){
						ani.SetBool("punch",true);
					}else{
						ani.SetBool("punch",false);
					}
				}

				//ani.SetBool ("isrun", true);

			} else {
				ani.SetBool ("isrun", false);
			}
			if (Input.GetKey (KeyCode.Space)){
				ani.SetBool("jump",true);

			}else{
				ani.SetBool("jump",false);
				if(Input.GetKey(KeyCode.Mouse1) ){
					ani.SetBool("kick",true);
				}else{
					ani.SetBool("kick",false);
					if( Input.GetKey(KeyCode.Mouse0)){
						ani.SetBool("punch",true);
					}else{
						ani.SetBool("punch",false);
					}
				}

			}
			ani.SetBool("Iswalking",true);

		} else {
			ani.SetBool("Iswalking",false);
			ani.SetBool("isrun",false);
			if (Input.GetKey (KeyCode.Space)){
				ani.SetBool("jump",true);
			}else{
				ani.SetBool("jump",false);
				if(Input.GetKey(KeyCode.Mouse1)){
					ani.SetBool("kick",true); 
				}else{
					ani.SetBool("kick",false);
					if( Input.GetKey(KeyCode.Mouse0)){
						ani.SetBool("punch",true);
					}else{
						ani.SetBool("punch",false);
					}
				}

			}
		}


	/*	if ((translation != 0) || (rotation != 0)) {
			translation *= Time.deltaTime;
			rotation *= Time.deltaTime;
			transform.Translate (0, 0, translation);
			transform.Rotate (0, rotation, 0);
			ani.SetBool ("Iswalking", true);
		} else {
			ani.SetBool("Iswalking",false);
		}  */
	}
}
