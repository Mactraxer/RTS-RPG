using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatKnigth : MonoBehaviour {
	public GameObject Point_Spawn;
	public GameObject Unit;
	public Vector3 EnemyPosition;
	public float Speed;
	public GameObject[] Units=new GameObject[30];
	public int Count=0;


	public void Create (){

		Vector3 pos_unit = Point_Spawn.transform.position;
		pos_unit.z = 0;//Чтобы был на весшем слое
		pos_unit.y = 1.1f; 
		EnemyPosition.y = 1.1f;//Меняем точку игрек чтобы юниты шли по линии
		EnemyPosition.z = 0;
		EnemyPosition.x = -45;
		Units[Count]= Instantiate (Unit,pos_unit,Quaternion.identity);
	    //Units [Count].transform.position = Vector3.MoveTowards (Units[Count].transform.position, EnemyPosition, Time.deltaTime);
		Count++;


	}
	// Use this for initialization
	void Start () {
	//	Point_Spawn=GameObject.FindGameObjectWithTag ("Castle"); 
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Count!=0)
			Units [Count-1].transform.position = Vector3.MoveTowards (Units[Count-1].transform.position, EnemyPosition, Time.deltaTime);	
	}
}
