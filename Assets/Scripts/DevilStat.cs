using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilStat : MonoBehaviour {


	public int HealthPoint=20;
	public int AttackStr=5;
	public float AttackSpeed;
	public int Expirience=0;
	public int Level=1;
	public int ExpCost = 20;
	public int ExpTop = 100;
	public GameObject[] UntisArea=new GameObject[100];
	public SysLvl sys;
	// Use this for initialization
	void Start () {
		sys = GameObject.FindGameObjectWithTag ("SystemLvl").GetComponent<SysLvl> ();
	}
	void Death(){
		//sys.AddExp (this.);
		Destroy (this.gameObject);

	
	}
	void LelelUp(){
		HealthPoint += 5;
		AttackStr += 2;
		Level++;
		ExpCost += ExpTop;
		ExpTop *= 2;

	}
	// Update is called once per frame
	void Update () {
		if (HealthPoint < 1)
			Death ();
	}
}
