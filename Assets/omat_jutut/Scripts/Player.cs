﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private float horisontaalinenPyorinta = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();
		
		//eteen ja sivulle liikkuminen
		float horizontal = Input.GetAxis("Horizontal") * 5;
        float vertical = Input.GetAxis("Vertical") * 5;
        Vector3 nopeus = new Vector3(horizontal, 0, vertical);
		
		//kääntyminen
		horisontaalinenPyorinta += Input.GetAxis("Mouse X") * 3;
		transform.localRotation = Quaternion.Euler(0, horisontaalinenPyorinta, 0);
        nopeus = transform.rotation * nopeus;
		
		//komento, jolla lopulta liikutaan
		hahmokontrolleri.SimpleMove(nopeus);
    }
}
