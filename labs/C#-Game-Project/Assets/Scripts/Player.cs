using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float playerHealth = 100f;
    public Image fillImage;
    public Text score_text;
    public int Score;
    public Image healthCol;
    float newHealth;
    // The start method is called once upon loading and is where I initialise some variable values
    void Start()
    {
        healthCol = GetComponent<Image>();
    }
    void Update()
    {
        GetHealth();
        PlayerControls();
        fillImage.fillAmount = (playerHealth / 100);
        if (playerHealth > 0.2 || playerHealth < 0.4)
        {
           // Debug.Log("its in orange");
        }
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    public float GetHealth()
    {
        newHealth = fillImage.fillAmount;
        return newHealth;  
    }
 // Player controls --- I used Unity's internal read keys Represented by the Horizontal or Vertical
    public void PlayerControls()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, Input.GetAxis("Vertical") * Time.deltaTime * speed);        
    }
    // Collision conditions regarding the player and the enemys
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "enemy_one")
        {
            playerHealth -= 1f;
            Debug.Log(playerHealth);
        }
        if (col.gameObject.name == "enemy_two")
        {
            playerHealth -= 2.5f;
        }
        if (col.gameObject.name == "enemy_three")
        {
            playerHealth -= 5f;
        }
        if (col.gameObject.name == "enemy_four")
        {
            playerHealth -= 5f;
        }
    }
    // Player health decrease
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "token")
        {
            playerHealth += 50f;
        }
    }

}
