using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBaseFSM : StateMachineBehaviour {

	public GameObject NPC;
	public Transform opponent;
	public float speed = 2.0f;
	public float rotSpeed = 1.0f;
	public float accuracy = 3.0f;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		NPC = animator.gameObject;

		//check if the NPC has been fully initialised
		//depending on when this runs the NPC might not have become fully awake
		if(NPC.GetComponent<AIController>())
			opponent = NPC.GetComponent<AIController>().player;
	}
}
