using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private GameObject EnemyPrefab;
    [SerializeField] private float LeftDistance;
    [SerializeField] private float UpDistance;
    private float x = 0;
    private float y = 0;

    public float timer = 2f;

    public int maxEnemyCount;
    public int currentEnemyCount;
    public List<Enemy> countEnemyInScene = new List<Enemy>();


    void Start()
    {
        currentEnemyCount = maxEnemyCount;
    }
    void Update()
    {
        if (currentEnemyCount > 0)
        {
        timer -=  Time.deltaTime;
        if(timer <= 0)
            {
                Spawn();
                timer = 2f;
            }
        }
    }
    public void Spawn()
    {

        x = Random.Range(-LeftDistance, LeftDistance);
        y = Random.Range(-UpDistance, UpDistance);
        if (Vector2.Distance(new Vector2(x, y), playerTransform.position) < 1f)
        {
            Spawn();
            return;
        }
        Instantiate(EnemyPrefab, new Vector3(x, y, 0), Quaternion.identity);
        currentEnemyCount--;
    }
    public void GetActuallyEnemyCount()
    {
        countEnemyInScene.Clear();
        
    }
}
