using System.Collections.Generic;
using UnityEngine;

public class EnemyCaller : MonoBehaviour
{
    public GameObject BasicEnemy;
    public GameObject BigEnemy;
    public GameObject HomingEnemy;

    public List<GameObject> EnemyList = new List<GameObject>();

    public int EnemyTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SpawnList(int EnemyTime)
    {



        if (EnemyTime == 0)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject temp1 = Instantiate(BasicEnemy, new Vector3(Random.Range(-5, 5), Random.Range(6, 9), 0), transform.rotation);
                temp1.SetActive(true);
                EnemyList.Add(temp1);
            }
        }
        if (EnemyTime == 1)
        {
            for (int i = 0; i < 2; i++)
            {
                GameObject temp2 = Instantiate(BigEnemy, new Vector3(Random.Range(-5, 5), Random.Range(6, 9), 0), transform.rotation);
                temp2.SetActive(true);
                EnemyList.Add(temp2);
            }
        }

        if (EnemyTime == 2)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject temp3 = Instantiate(HomingEnemy, new Vector3(Random.Range(-5, 5), Random.Range(6, 9), 0), transform.rotation);
                temp3.SetActive(true);
                EnemyList.Add(temp3);
            }
        }

     
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
