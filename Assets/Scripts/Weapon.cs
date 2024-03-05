using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    protected int _damage;
    public int killCount;
    protected Vector2 _cursorPosition;
    [SerializeField] protected SpriteRenderer _weaponRenderer;

    public void TurnToCursor()
    {
        _cursorPosition = Input.mousePosition;
        //transform.LookAt(new Vector3(0, 0, _cursorPosition.y));

        //Vector3 targetRotation = new Vector3(_cursorPosition.x, _cursorPosition.y, 0) - transform.position;
        //float angle = Mathf.Atan2(targetRotation.y, targetRotation.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(angle);

        //transform.rotation = Quaternion.LookRotation(new Vector2(_cursorPosition.x, _cursorPosition.y), transform.up); // сделать направление к курсору
    }
}
