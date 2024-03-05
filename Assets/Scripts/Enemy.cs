using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;
    public float speed;
    public Transform playerTransform;
    public int pointsCount;

    protected Animator EnemyAnimator;
    protected AnimationClip[] animationClips;
    protected Collider2D enemyCollider;
    protected SpriteRenderer enemyRenderer;
    protected GameConditions _GameConditions;

    private void Start()
    {
        _GameConditions = FindObjectOfType<GameConditions>();
        EnemyAnimator = GetComponent<Animator>();
        enemyCollider = GetComponent<Collider2D>();
        playerTransform = FindObjectOfType<Move>().transform;
        enemyRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }
    // создать метод инициализации закрытых переменных
    public void Death() // сделать метод виртуальным
    {
        enemyCollider.isTrigger = true;
        _GameConditions.score += pointsCount;
        _GameConditions.CheckScore();
        EnemyAnimator.SetTrigger("DeathTrigger");
        speed = 0;
        DestroyObject();
        Invoke("DestroyObject", 3f);
    }
    public void DestroyObject() // zombies animation doesnt change
    {
        Destroy(gameObject);
    }
    public void SetPrivateVariablesCount()
    {
        _GameConditions = FindObjectOfType<GameConditions>();
        EnemyAnimator = GetComponent<Animator>();
        enemyCollider = GetComponent<Collider2D>();
        playerTransform = FindObjectOfType<Move>().transform;
        enemyRenderer = GetComponent<SpriteRenderer>();
    }
    public void MoveAndRotateToPlayer()
    {
        if (playerTransform.position.x > transform.position.x)
        {
            enemyRenderer.flipX = false;
        }
        else
        {
            enemyRenderer.flipX = true;
        }
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Death();
        }
    }
}
