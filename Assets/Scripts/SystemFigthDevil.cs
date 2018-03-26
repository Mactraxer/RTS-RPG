using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemFigthDevil : MonoBehaviour {
	public Animator Anim;
	//Vector2 force=(-1, 1); 
	public SpriteRenderer SpriteUnit;
	public GameObject Target;
	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator>();
		SpriteUnit=GetComponent<SpriteRenderer>();
	}

	void OnTriggerStay2D (Collider2D object1)
	{
		if (object1.gameObject.name.Contains("Knigth"))
			Target = object1.gameObject;

	}

	void OnTriggerExit2D (Collider2D object1)
	{
		if (object1.gameObject.name.Contains("Knigth"))
			Target = null;

	}
	void Attack(){
		
		Rigidbody2D rb=Target.GetComponent<Rigidbody2D>();
		Stats StatEnemy=Target.GetComponent<Stats>();
		Stats StatUnit=GetComponent<Stats>();
		StatEnemy.HealthPoint -= StatUnit.AttackStr;
		rb.AddForce (Vector2.left);
		Debug.Log ("Демон ранил Воина на "+StatUnit.AttackStr+" ед. урона");

	}

	// Update is called once per frame
	void Update () {
		
	}
}
