using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SysLvl : MonoBehaviour {
	public List <GameObject> Units=new List<GameObject>();
	//public int Count=0;
	public Stats ExpG,ExpS;
	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D (Collider2D col){
		Debug.Log (col.gameObject.name);
		Units.Add(col.gameObject);

	}
	void OnTriggerExit2D (Collider2D col){

		//for (int i = 0; i < Units.Length; i++) {

			//Units [Count++] = col.gameObject;
		//}


	}

	public void AddExp(int exp){
		Debug.Log ("Враг побеждён. Все получат  -"+exp+" опыта");
		//GameObject obj = GameObject.Find (str);
		//Debug.Log ("GameObject Name -"+obj.name);
		foreach (GameObject unit in Units) {
			if (unit == null)
				continue;
			Debug.Log ("In foreaach. Count units:"+Units.Count);
			//ring nameStat=unit.name+"Stat";
		//	Component stat=unit.GetComponent<>();
			Debug.Log (unit.name+" получает -"+exp+" опыта!"); 
			ExpG=unit.GetComponent<Stats>();
			//ExpS = obj.GetComponent<Stats> ();
			ExpG.Expirience += exp;

		}
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
