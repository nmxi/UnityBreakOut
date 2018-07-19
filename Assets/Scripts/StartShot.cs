using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
