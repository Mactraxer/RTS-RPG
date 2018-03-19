using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemFigthKnigth : MonoBehaviour {


	public Animator Anim;
	public SpriteRenderer SpriteUnit;
	public GameObject Target;
	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator>();
		SpriteUnit=GetComponent<SpriteRenderer>();
	}

	void OnTriggerStay2D (Collider2D object1)
	{
		if (object1.gameObject.name == "Devil")
			Target = object1.gameObject;

	}
	void OnTriggerExit2D (Collider2D object1)
	{
		if (object1.gameObject.name == "Devil")
			Target = null;

	}

	void Attack(){
		Stats StatEnemy=Target.GetComponent<Stats>();
		Stats StatUnit=GetComponent<Stats>();
		StatEnemy.HealthPoint -= StatUnit.AttackStr;
		Debug.Log ("Воин ранил Демона на "+StatUnit.AttackStr+" ед. урона");

	}



	// Update is called once per frame
	void Update () {
		
	}
}
