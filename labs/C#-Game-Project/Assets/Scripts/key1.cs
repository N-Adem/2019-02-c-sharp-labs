using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class key1 : MonoBehaviour
{
    public Text score_text;
    public GameObject gate1;
    void Start()
    {
    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("key one destroyed");
            Destroy(gameObject);
            Destroy(gate1);
        }
    }
  
}
