using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();
        Vector3 nopeus = new Vector3(0, 0, 1);
        hahmokontrolleri.Move(nopeus * Time.deltaTime);
    }
}
