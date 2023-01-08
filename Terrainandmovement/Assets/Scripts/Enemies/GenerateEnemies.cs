using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public int enemyCount;
    public int enemyCount1;
    public int enemyCount2;
    public int enemyCount3;
    void Start()
    {
        
        StartCoroutine(EnemySpawn());
        StartCoroutine(EnemySpawn1());
        StartCoroutine(EnemySpawn2());
        StartCoroutine(EnemySpawn3());
    }
    
    IEnumerator EnemySpawn()
    {
        yield return new WaitForSeconds (6.0f);
        while (enemyCount < 5 )
        {
            xPos = Random.Range(-30,31);
            zPos = Random.Range(30,14);

            Instantiate(theEnemy, new Vector3(xPos,1,zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount +=1;
        }
    }
    IEnumerator EnemySpawn1()
    {
        yield return new WaitForSeconds (6.0f);;
        while (enemyCount1 < 5 )
        {
            xPos1 = Random.Range(30,15);
            zPos1 = Random.Range(30,-30);

            Instantiate(theEnemy, new Vector3(xPos1,1,zPos1),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount1 +=1;
        }
    }
    IEnumerator EnemySpawn2()
    {
        yield return new WaitForSeconds (6.0f);
        while (enemyCount2 < 5 )
        {
            xPos2 = Random.Range(30,-30);
            zPos2 = Random.Range(-30,-15);

            Instantiate(theEnemy, new Vector3(xPos2,1,zPos2),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount2 +=1;
        }
    }
    IEnumerator EnemySpawn3()
    {
        yield return new WaitForSeconds (6.0f);
        while (enemyCount3 < 5 )
        {
            xPos3 = Random.Range(-30,-15);
            zPos3 = Random.Range(-30,30);

            Instantiate(theEnemy, new Vector3(xPos3,1,zPos3),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount3 +=1;
        }
    }
}
