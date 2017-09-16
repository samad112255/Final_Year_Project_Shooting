using UnityEngine;
using System.Collections;

public class raycast : MonoBehaviour {

	public int gundamage = 1;
	public float firerate = .25f;
	public float weaponrange = 50f;
	public float hitforce = 100f;
	public Transform gunEnd;

	public Camera tpscam;
	private WaitForSeconds shotduration = new WaitForSeconds(.07f);
	private float nextfire;
	public LineRenderer laser;
	void Start () {
		tpscam = GetComponentInParent<Camera>();

	}
	

	void Update () {
	
		if (Input.GetMouseButtonDown(0)) 
		{
			nextfire = Time.time + firerate; 
			StartCoroutine(shotEffect());
			Vector3 rayorigin = tpscam.ViewportToWorldPoint(new Vector3(0.5f,0.5f,0));
			RaycastHit hit;
			laser.SetPosition(0,gunEnd.position);
			if(Physics.Raycast(rayorigin,tpscam.transform.forward,out hit, weaponrange))
			{
				laser.SetPosition(1,hit.point);
				getdamage health = hit.collider.GetComponent<getdamage>();
				if(health != null){
					health.Damage(gundamage);
				}
				if(hit.rigidbody != null )
				{
					hit.rigidbody.AddForce(-hit.normal * hitforce);
				}

		}
			else
			{
				laser.SetPosition(1,rayorigin + (tpscam.transform.forward * weaponrange));
			}
	}
}
	private  IEnumerator shotEffect()
	{
		laser.enabled = true;
		yield return shotduration;
		laser.enabled = false;
	}
}