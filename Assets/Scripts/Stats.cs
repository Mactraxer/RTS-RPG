using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {


	public int HealthPoint;
	public int AttackStr;
	public float AttackSpeed;
	public int Expirience;
	public int Level;
	public int ExpCost;//Expirience+ExpCost отдаётся при смерти
	public int ExpTop;

	public SysLvl sysl;
	public SysStats syss;
	// Use this for initialization
	void Start () {
		sysl = GameObject.Find("SystemLvl").GetComponent<SysLvl> ();
		syss = GameObject.Find("SystemStats").GetComponent<SysStats> ();
		syss.SetStat (gameObject);


	}
	void Death(){

		//sysl.AddExp (gameObject.name);
		//Destroy (gameObject);



	}
	void LelelUp(){
		HealthPoint += 5;
		AttackStr += 2;
		Level++;
		ExpCost += ExpTop;
		ExpTop *= 2;

	}
	void OnDestroy(){
		sysl.Units.Remove (gameObject);
		sysl.AddExp (Expirience+ExpCost);

	}
	// Update is called once per frame
	void Update () {
		if (HealthPoint < 1)
			Destroy (gameObject);
	}
}
