using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Panel Components")]
    public GameObject failedPanel;
    public GameObject completePanel;
    public static GameManager instance;

    [Header("Enemy Components")]
    public GameObject[] Enemy;
    public GameObject currentEnemy;
    public int currEnemy;
    public GameObject animCam;
    public GameObject Maincam;

    public GameObject player;


    [Header("CutScene")]
    //public GameObject cutScene;

    public GameObject blur;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        //cutScene.SetActive(true);
        StartCoroutine(nameof(AnimCamDelay));
        currentEnemy = Enemy[currEnemy];
        currEnemy = Enemy.Length;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

     public void GameCompleted()
    {
        currEnemy--;
        currentEnemy = Enemy[currEnemy];
    }

     IEnumerator  AnimCamDelay()
    {
        animCam.SetActive(true);
        yield return new WaitForSeconds(5f);
        animCam.SetActive(false);
        player.SetActive(true);
        yield return null;
    }

}
