using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateEnemies : MonoBehaviour
{
    
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int xPos1;
    public int zPos1;
    public int xPos2;
    public int zPos2;
    public int xPos3;
    public int zPos3;
    public int enemyCount = 0;
    public int enemyCount1 = 0;
    public int enemyCount2 = 0;
    public int enemyCount3 = 0;
    public int Score;
    public int CurrentEnemies;
    public static int Level;
    public static int TempScore;
    public int TotalScore;
    public int AmountToSpawn;
    bool EnemyOn = false;
    public static bool DispLevel;
    public Text LevelText; 
    public static bool EasyMode = false;
    public static bool MediumMode = false;
    public static bool HardMode = false;
    void Start()
    {
        Level = 1;   
        enemyCount = 0;
        enemyCount1 = 0;
        enemyCount2 = 0;
        enemyCount3 = 0;
        StartCoroutine(EnemySpawn());
        StartCoroutine(EnemySpawn1());
        StartCoroutine(EnemySpawn2());
        StartCoroutine(EnemySpawn3());
        
    }
    

void Update()
{
    if (EasyMode)
    {
        AmountToSpawn = 2*Level;
    }
    if (MediumMode)
    {
        AmountToSpawn = 2*(Level+1);

    }
    if (HardMode)
    {
        AmountToSpawn = 3*(Level+2);
    }
   
    Debug.Log(AmountToSpawn);
    LevelText.text = Level.ToString();
    CurrentEnemies = AmountToSpawn*4 - TempScore;
         
    if(EnemyOn && CurrentEnemies == 0)
    {
        EnemyOn = false;
        Level = Level + 1;
        StartCoroutine(EnemySpawn());
        StartCoroutine(EnemySpawn1());
        StartCoroutine(EnemySpawn2());
        StartCoroutine(EnemySpawn3());
        enemyCount = 0;
        enemyCount1 = 0;
        enemyCount2 = 0;
        enemyCount3 = 0;
        TempScore = 0;
    }
}


   IEnumerator EnemySpawn()
    {
        yield return new WaitForSeconds (5.0f);
        while (enemyCount < AmountToSpawn )
        {
            xPos = Random.Range(-30,31);
            zPos = Random.Range(30,14);

            Instantiate(theEnemy, new Vector3(xPos,1.2f,zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount++;
            EnemyOn = true;
        }
        
    }
    IEnumerator EnemySpawn1()
    {
        
        yield return new WaitForSeconds (5.0f);
        while (enemyCount1 < AmountToSpawn )
        {
            xPos1 = Random.Range(30,15); //range finder
            zPos1 = Random.Range(30,-30); 

            Instantiate(theEnemy, new Vector3(xPos1,1.2f,zPos1),Quaternion.identity); //the spawner
            yield return new WaitForSeconds(0.1f);

            enemyCount1++;
            EnemyOn = true;
        }

        
    }
    IEnumerator EnemySpawn2()
    {
        yield return new WaitForSeconds (5.0f);
        while (enemyCount2 < AmountToSpawn )
        {
            xPos2 = Random.Range(30,-30);
            zPos2 = Random.Range(-30,-15);

            Instantiate(theEnemy, new Vector3(xPos2,1.2f,zPos2),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount2++;
            EnemyOn = true;
        }
    }
    IEnumerator EnemySpawn3()
    {
        DispLevel = true;
        yield return new WaitForSeconds (5.0f);
        DispLevel = false;
        while (enemyCount3 < AmountToSpawn )
        {
            xPos3 = Random.Range(-30,-15);
            zPos3 = Random.Range(-30,30);

            Instantiate(theEnemy, new Vector3(xPos3,1.2f,zPos3),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount3++;
            EnemyOn = true;
        }

    }
}

