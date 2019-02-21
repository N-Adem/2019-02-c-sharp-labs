using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Keys : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Object hit");
            Destroy(gameObject);
        }
    }
}     
