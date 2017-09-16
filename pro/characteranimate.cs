using UnityEngine;
using System.Collections;

public class characteranimate : MonoBehaviour {

	static Animator ani;
	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	/*	if (Input.GetAxis ("Mouse X") || Input.GetAxis("Vertical")) {
			ani.SetBool("iswalk",true);
		}
		else{
			if(Input.GetAxis("Vertical") && Input.Getkey(KeyCode.LeftShift)){ 
				ani.SetBool("iswalk",false);
				ani.SetBool("isrun",true);
			}
			else{
				if(Input.GetKey(KeyCode.Mouse0)){
					ani.SetBool("shoot",true);
				}
			}*/

			
			if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
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


