using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class key2 : MonoBehaviour
{
    private GameObject Door;
    public Light puzzleLight;
    void Start()
    {
        puzzleLight.GetComponent<Light>().enabled = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Destroy(gameObject);
            puzzleLight.enabled = true;
        }
    }
}
