using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    [SerializeField] private Rigidbody2D _bulletBody;
    [SerializeField] private float _shootForce;
    [SerializeField] private Collider2D _playerCollider;
    [SerializeField] private Collider2D _bulletCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy;
        if (collision.gameObject.GetComponent<Enemy>())
        {
            // ошибки нет
            enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(damage);
        }
        
    }
    void Start()
    {
        _bulletCollider = gameObject.GetComponent<Collider2D>();
        _bulletBody.AddForce(Vector2.right * _shootForce, ForceMode2D.Impulse);
        _playerCollider = FindObjectOfType<PlayerHealth>().gameObject.GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(_playerCollider, _bulletCollider);
    }
}
