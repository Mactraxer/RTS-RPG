using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilAnimationAttack : MonoBehaviour {
	public Animator Anim;
	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator>();
	}
	void OnTriggerEnter2D (Collider2D object1)
	{
		//Debug.Log ("Collision");

		if (object1.gameObject.name.Contains("Knigth"))
			Anim.SetBool ("Collision", true);


	}
	void OnTriggerExit2D(Collider2D object1){

		if (object1.gameObject.name.Contains("Knigth"))
			Anim.SetBool ("Collision", false);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
