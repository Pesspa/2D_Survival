using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    // maxHealth for reload health
    public Enemy enemy;
    public Heart[] arrayOfHearts;


    [SerializeField] private AudioSource audioPlayer;
    [SerializeField] private AudioClip deathSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Enemy>())
        {
            enemy = collision.gameObject.GetComponent<Enemy>();
            TakeDamage(enemy.damage);
            enemy = null;
            ShowHealth();
        }
        //if (collision.gameObject.GetComponent<EnemyWeapon>())
        //{
        //    EnemyWeapon weapon = collision.gameObject.GetComponent<EnemyWeapon>();
        //    TakeDamage(weapon.damage);
        //    weapon = null;
        //    ShowHealth();
        //}
    }
    void Start()
    {
         
    }
    public void TakeDamage(int damage)
    {
        audioPlayer.clip = deathSound;
        audioPlayer.Play();
        health -= damage;
        ShowHealth();
    }
    void ShowHealth()
    {
        for (int i = 0; i < arrayOfHearts.Length; i++)
        {
            if(i < health)
            {
                arrayOfHearts[i].gameObject.SetActive(true);
            }
            else
            {
                arrayOfHearts[i].SetTriggerDestroy();
            }
        }
    }

}
