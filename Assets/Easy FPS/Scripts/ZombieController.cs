using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ZombieController : MonoBehaviour
{
    public Animator EnemyAnimator;
    public GameObject Player;
    public GameObject cube;
    public static ZombieController instance;
    public bool ishealth ;
    public bool isdied = false;

    private void Awake()
    {
        instance = this;
    }
   

    private void Update()
    {
        if (Player.GetComponent<PlayerMovementScript>().isGrounded)
        {
            EnemyAnimator.SetBool("walk", true);
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 0.7f * Time.deltaTime);
            transform.LookAt(Player.transform);
        }
      
    }
    public void Death()
    {
        this.gameObject.transform.LookAt(Player.transform.position);
            EnemyAnimator.SetBool("death", true);
            Destroy(gameObject, 4f);
            GameManager.instance.GameCompleted();
           
    }


}
