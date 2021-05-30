using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

	public Transform player;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//let all the state stuff be organised by the state machine in the animator
		//just update the animator transition conditions here and send them through
		anim.SetFloat("distance", Vector3.Distance(transform.position,player.transform.position));	
		anim.SetFloat("visangle", Vector3.Angle(this.transform.forward,player.transform.position - transform.position));	
	}
}
