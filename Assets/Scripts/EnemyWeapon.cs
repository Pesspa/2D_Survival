using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public int damage;
    public PlayerHealth PlayerHealth;
    [SerializeField] private Rigidbody2D body;

    private void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1000f * Time.deltaTime));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHealth>())
        {
            body.isKinematic = true;
            PlayerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            PlayerHealth.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
