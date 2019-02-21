using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Light light;
    public Transform player;
    public GameObject bullet;
    float power = 20.0f;
    public float thrust;
    void Start()
    {
        light.GetComponent<Light>();
    }
    void Update()
    {
        gameObject.transform.LookAt(player.transform.localPosition);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.name == "Player")
        {
            light.color = Color.red;
            GameObject bullet02 = (GameObject)Instantiate(bullet);
            bullet.transform.position = transform.position + transform.forward * 0.6f;
            Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
            //bulletRB.velocity = Vector3.zero;
           // bulletRB.AddForce(transform.forward * power, ForceMode.VelocityChange);
        }
    }
    void OnTriggerLeave(Collider other)
    {
        if (other.name == "Player")
        {
            light.color = Color.white;
       
        }
    }
}
