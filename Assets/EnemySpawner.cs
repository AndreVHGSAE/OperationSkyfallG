using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class EnemySpawner : MonoBehaviour
{
    public GameObject BasicEnemy;
    public GameObject BigEnemy;
    public GameObject HomingEnemy;

    public List<GameObject> EnemyList = new List<GameObject>();

    float currentTime;
    public float maxTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= maxTime)
        {
            GameObject temp = getEnemy();
            temp.SetActive(true);
            currentTime = 0;
        }
    }

    GameObject getEnemy()
    {
        foreach (GameObject temp1 in EnemyList)
        {
            if (temp1.activeInHierarchy == false)
            {
                return temp1;
            }
        }
        GameObject newEnemy1 = Instantiate(BasicEnemy, transform.position, Quaternion.identity);
        GameObject newEnemy2 = Instantiate(BigEnemy, transform.position, Quaternion.identity);
        GameObject newEnemy3 = Instantiate(HomingEnemy, transform.position, Quaternion.identity);
        newEnemy1.SetActive(false);
        newEnemy2.SetActive(false);
        newEnemy3.SetActive(false);
        EnemyList.Add(newEnemy1);
        EnemyList.Add(newEnemy2);
        EnemyList.Add(newEnemy3);
        return newEnemy1;
        return newEnemy2;
        return newEnemy3;
    }
}

