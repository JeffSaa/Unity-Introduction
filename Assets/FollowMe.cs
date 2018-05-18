using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour {
    
    public GameObject toFollow;
        
	void Start () {
        
    }
	
	void Update () {
		var distance = Vector3.Distance(transform.position, toFollow.transform.position);
        if (distance > 13)
        {
            GetComponent<Animator>().enabled = true;
            Vector3 position =  transform.position + transform.forward * 0.1f;
            position.y = 4f;
            transform.position = position;
            Vector3 targetPoint = toFollow.transform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint, Vector3.up);
            transform.rotation = targetRotation;
        }
        else
            GetComponent<Animator>().enabled = false;
    }

}