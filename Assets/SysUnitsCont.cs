using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SysUnitsCont : MonoBehaviour {
	public GameObject[] Units=new GameObject[80];
	public int Count=0;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		Add (col.gameObject);
	
	}
	void OnTriggerExit2D(Collider2D col){
		Delete (col.gameObject);

	}
	void Add(GameObject obj){
		Units [Count] = obj;
		Count++;
	
	}
	void Delete(GameObject obj){
		int posD;

		for (int i = 0; i < Units.Length; i++)
			if (obj.name == Units [i].name) {
				posD = i; break;
			}
		for (int i = posD; i < Units.Length - 1; i++)
			Units [i] = Units [i + 1];
		Units [Units.Length-1] = null;

		}

	}
	// Update is called once per frame
	void Update () {
		
	}
}
