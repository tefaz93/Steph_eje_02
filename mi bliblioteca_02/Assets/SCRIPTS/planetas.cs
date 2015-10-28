using UnityEngine;
using System.Collections;

public class planetas : MonoBehaviour {
	public GameObject center;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//Permite girar un objeto al rededor de otro
		//lo busque en google como rotate around unity
		transform.RotateAround (new Vector3(0,10,0), Vector3.up, speed * Time.deltaTime);
	}
}
