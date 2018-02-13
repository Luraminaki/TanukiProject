﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttunSelected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Vertical") != 0 && buttunSelected == false) {
            eventSystem.SetSelectedGameObject(selectedObject);
            buttunSelected = true;
        }
	}

    private void OnDisable() {
        buttunSelected = false;
    }
}
