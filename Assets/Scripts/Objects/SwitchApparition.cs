using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchApparition : MonoBehaviour
{


    public GameObject porte;


    // Use this for initialization
    void Start()
    {
    }


    void OnCollisionEnter(Collision collider)
    {

			porte.SetActive (true);
		
    }


    // Update is called once per frame
    void Update()
    {

    }
}
