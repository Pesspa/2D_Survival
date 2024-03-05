using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : DistanceWeapon
{

    void Update()
    {
        TurnToCursor();
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Shoot();
                timer = timeToReload;
            }
        }
        _cursorPosition = Input.mousePosition;
        if (_cursorPosition.x < Screen.width / 2)
        {
            _weaponRenderer.flipX = true;
        }
        else
        {
            _weaponRenderer.flipX = false;
        }
    }
    
}
