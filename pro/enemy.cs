using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	public float deathDistance;
	public float distanceAway;
	public Transform thisObject;
	public Transform target;
	private NavMeshAgent navComponent;
	static Animator zani;

	
	void Start() 
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
		navComponent = this.gameObject.GetComponent<NavMeshAgent>();
		zani = GetComponent<Animator> ();
	}
	
	void Update() 
	{
		
		float dist = Vector3.Distance(target.position, transform.position);
		
		if(target)
		{
			navComponent.SetDestination(target.position);
		}
		
		else
		{
			if(target = null)
			{
				target = this.gameObject.GetComponent<Transform>();
			}
			else
			{
				target = GameObject.FindGameObjectWithTag("Player").transform;
			}
		}
		if (dist < deathDistance)
		{
			if(Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1)){
			
				zani.SetBool("gethit",true);
			}
			else{
				zani.SetBool("gethit",false);

			}
				//KILL PLAYER
		}

	
	}
}
