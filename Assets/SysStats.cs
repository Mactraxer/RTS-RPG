using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SysStats : MonoBehaviour {

	public int HealthPoint;
	public int AttackStr;
	public float AttackSpeed;
	public int Expirience;
	public int Level;
	public int ExpCost;
	public int ExpTop;
	public Stats Script;

	public void SetStat(GameObject obj){
		//Script = obj.GetComponent<Stats> ();
		//bool sw=obj.name.Contains("Devil");
		if (obj.name.Contains ("Devil"))
			DevilStats (obj);
		if (obj.name.Contains ("Knigth"))
			KnigthStats (obj);
	}
	void DevilStats(GameObject obj){

		Script = obj.GetComponent<Stats> ();
		Script.HealthPoint = 2;
		Script.AttackStr=5;
		Script.AttackSpeed=0.2f;
		Script.Expirience=0;
		Script.Level=1;
		Script.ExpCost = 20;
		Script.ExpTop = 100;
	
	}

	void KnigthStats(GameObject obj){

		Script = obj.GetComponent<Stats> ();
		Script.HealthPoint =5 ;
		Script.AttackStr=1;
		Script.AttackSpeed=0.2f;
		Script.Expirience=0;
		Script.Level=1;
		Script.ExpCost = 5;
		Script.ExpTop = 20;

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
