using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puzzle2 : Player
{
    public Light activelight;
    public Light secondLight;
    public Text timerText;
    public Text missionText;
    public GameObject key;
    public GameObject Door;
    public GameObject chest;
    public Transform keySpawnPoint;
    private float timer;
    private bool isPuzzleActive = false;
    private bool isSpawn = false;
    private float tempHealth;
    // Initiallised some variable values which will be used for the methods below
    void Start()
    {
        timer = 0.0f;
        missionText.enabled = false;
        activelight.GetComponent<Light>();
        secondLight.GetComponent<Light>().enabled = false;
        key.SetActive(true);
        Door.SetActive(true);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Object hit");
            secondLight.enabled = false;
            Door.SetActive(false);
            key.SetActive(false);
           
        }
    }
    // Update runs on a loop which goes every frame
    void Update()
    {
        // Pulling the Health value from the base(player class) and updating it for puzzle specific executions
        tempHealth = GetHealth();
        //Debug.Log("Player Health is" + tempHealth);
        if (activelight.enabled == true)
        {
            isPuzzleActive = true;
            if (isPuzzleActive == true)
            {
                Timer(tempHealth);               
            }
        }
    }
    // used to generate the key for the door
    private void GenDoorKey()
    {
        isSpawn = true;
       // key.SetActive(true);
        //Instantiate(key, keySpawnPoint);
    }
    /* Small timer method which counts up and displays to text in game, 
     * its also used to activate certain things in game
    */
    private void Timer(float pHealth)
    {
        timer += 0.02f;
        missionText.enabled = true;
        secondLight.enabled = true;
        timerText.text = "Time:" + (int)timer;
        GenDoorKey();
        if (timer >= 3)
        {
            chest.SetActive(false);
            missionText.enabled = false;
        }
        if (timer > 5.0f)
        {
            if (tempHealth <= 0.3f)
            {
                Debug.Log("Enemies slow down");
            }
        }
    }
    
}
