using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Animator animator;
    [SerializeField] private SpriteRenderer _playerRenderer;
    private Vector2 _cursorPosition;
    void Update()
    {
        _cursorPosition = Input.mousePosition;
        if(_cursorPosition.x < Screen.width / 2)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
            //_playerRenderer.flipX = true;  
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            //_playerRenderer.flipX = false;
        }
        float vertical = Input.GetAxis("Vertical"); 
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(vertical * transform.up * speed * Time.deltaTime);
        transform.Translate(horizontal * transform.right * speed * Time.deltaTime);
        if(vertical == 0 &&  horizontal == 0)
        {
            animator.Play("Idle");
        }
        else
        {
            animator.Play("Move");
        }
    }
}
