using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerDeduct : MonoBehaviour
{
    public int health;
    public Slider healthBar;
    public static TriggerDeduct instance;
    public bool isblurr = true;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {

        healthBar.value = health;

        if (health == 0)
        {
            GameManager.instance.failedPanel.SetActive(true);
        }

        if (health <= 5)
        {
            //mouth spitting animation
        }

        if (health <= 2)
        {
            if (isblurr)
            {
                GameManager.instance.blur.SetActive(true);
            }
            if (!isblurr)
            {
                GameManager.instance.blur.SetActive(false);
            }
       
        }

        if (GameManager.instance.currEnemy == 0)
        {
            GameManager.instance.completePanel.SetActive(true);
        }
    }
   
}
