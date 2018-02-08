﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirStream : MonoBehaviour {



	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {

            if (other.gameObject.GetComponent<CharacterController>().GetInteractState() == InteractState.Glide) {
                Rigidbody bodyObject = other.gameObject.GetComponent<Rigidbody>();
                //bodyObject.AddForce(Vector3.up * 100 + (Vector3.up * Mathf.Abs(bodyObject.velocity.y)), ForceMode.Force);
                bodyObject.velocity = new Vector3(bodyObject.velocity.x, 0, bodyObject.velocity.z);
                bodyObject.AddForce(Vector3.up * 80, ForceMode.Impulse);
            }
            

        }
        
    }

    private void OnTriggerStay(Collider other) {

        if (other.gameObject.CompareTag("Player")) {
            if (other.gameObject.GetComponent<CharacterController>().GetInteractState() == InteractState.Glide) {
                Rigidbody bodyObject = other.gameObject.GetComponent<Rigidbody>();
                bodyObject.AddForce(Vector3.up * 100 + (Vector3.up * Mathf.Abs(bodyObject.velocity.y)), ForceMode.Force);
            }
        }
        
    }



}