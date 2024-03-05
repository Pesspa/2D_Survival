using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceWeapon : Weapon
{
    public GameObject bulletPrefab;
    public Transform spawnPosition;
    [SerializeField] protected float timeToReload;
    [SerializeField] protected AudioSource audioPlayer;
    [SerializeField] protected AudioClip soundShot;
    protected float timer;
    
    public void Shoot()
    {
        bulletPrefab.gameObject.GetComponent<Bullet>().damage *= 2;
        audioPlayer.clip = soundShot;
        audioPlayer.Play();
        Instantiate(bulletPrefab, spawnPosition.position, spawnPosition.rotation);
    }
}
