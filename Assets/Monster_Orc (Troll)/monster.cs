using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    int layer_index;
    private int horisontaalinenPyorinta = 0;
    public int speed = 1;
    void Start()
    {
        layer_index = LayerMask.GetMask("wall");
    }

    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();
        Vector3 nopeus = new Vector3(0, 0, speed);

        //kääntyminen
       
        transform.localRotation = Quaternion.Euler(0, horisontaalinenPyorinta, 0);
        nopeus = transform.rotation * nopeus;


        hahmokontrolleri.Move(nopeus * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("wall"))
        {
            int kaannos = Random.Range(90, 270);
            print("osuin seinaan");
            horisontaalinenPyorinta += kaannos;
            speed += 1;
        }
    }

    }
