using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>() != null)
        {
            Death();
        }
    }
    void Start()
    {
        SetPrivateVariablesCount();
    }
    void Update()
    {
        MoveAndRotateToPlayer();
        if (health <= 0)
        {
            Death();
        }
    }
}
