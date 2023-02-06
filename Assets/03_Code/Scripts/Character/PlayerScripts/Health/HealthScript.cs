using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public float timeInvincible = 2.0f;
    bool isInvincible = false;
    float invincibleTimer;

    void Update()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)

    {
        DealsDMGtoPlayer temp = other.gameObject.GetComponent<DealsDMGtoPlayer>();
        if ((temp != null) && isInvincible == false)
        {
            isInvincible = true;
            invincibleTimer = timeInvincible;
            
            health = health - 1;

        }        
    }
}
