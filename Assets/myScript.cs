using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //moves object up 0.1 per frame
        //transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
    }

    void OnCollisionEnter(Collision collision){
        transform.position = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
    }
}
