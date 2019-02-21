using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_two : MonoBehaviour
{
    Vector3 currentPos;
    public GameObject player;
    Vector3 playerDir;

    void Update()
    {
        // gameObject.transform.LookAt(player.transform.localPosition);
    }

    void OnTriggerStay(Collider other)          
    {
        if (other.name == "Player")
        {
            currentPos = gameObject.GetComponent<Transform>().position;
            playerDir = player.GetComponent<Transform>().position - currentPos;
            transform.Translate(playerDir * Time.deltaTime);
        }
    }
}
