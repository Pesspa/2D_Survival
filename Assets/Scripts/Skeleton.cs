using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    public int charge;
    public float timeToReloadCharge;
    public float currentTime;
    public float distanceAttack;
    public GameObject weaponPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>() != null)
        {
            Death();
        }
    }
    private void Start()
    {
        SetPrivateVariablesCount();
    }
    private void Update()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0)
        {
            if(charge > 0)
            {
                SpecialAttack();

            }
        }
        MoveAndRotateToPlayer();
    }
    private void SpecialAttack()
    {
        if(Vector3.Distance(transform.position, playerTransform.position) < distanceAttack)
        {
            Instantiate(weaponPrefab, transform.position, Quaternion.identity);
            // бросок в сторону игрока
        }
    }
}
