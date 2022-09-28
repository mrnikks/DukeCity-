using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthdeduct : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
    
        if (other.tag == "Juice")
        {
           TriggerDeduct.instance.healthBar.value = 10;
            TriggerDeduct.instance.health = 10;
        }

    }
}
