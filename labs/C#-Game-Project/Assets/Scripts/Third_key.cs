using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third_key : MonoBehaviour
{
    public GameObject door;
    void Start()
    {
        door.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Key hit woooooooooo");
            //door.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
