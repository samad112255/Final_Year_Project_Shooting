using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public float sens = 10;
    public float distance = 1;
	public Transform target;
	public float rst = .12f;
	public float pitchmin = -30;
	public float pitchmax = 50;
	Vector3 rsv;
	Vector3 cr;

    private float yaw = 0.0f;
    private float pitch = 0.0f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {

        yaw +=  Input.GetAxis("Mouse X") * sens;
		pitch -= Input.GetAxis ("Mouse Y") * sens;
		pitch = Mathf.Clamp (pitch, pitchmin, pitchmax);

		cr = Vector3.SmoothDamp (cr, new Vector3 (pitch, yaw), ref rsv,rst);
		transform.eulerAngles = cr;
		transform.position = target.position - transform.forward * distance; 


    }
}
