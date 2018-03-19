using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnigthSta : MonoBehaviour {

	public int HealthPoint=5;
	public int AttackStr=1;
	public float AttackSpeed;
	public int Expirience=0;
	public int Level=1;
	public int ExpCost = 5;
	public int ExpTop = 20;

	// Use this for initialization

	void LelelUp(){
		HealthPoint += 5;
		AttackStr += 2;
		Level++;
		ExpCost += ExpTop;
		ExpTop *= 2;
	
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
