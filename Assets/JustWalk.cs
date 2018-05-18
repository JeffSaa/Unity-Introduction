using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustWalk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        position.z += 0.1f;
        transform.position = position;
	}
}
