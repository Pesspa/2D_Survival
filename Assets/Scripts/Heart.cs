using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public Animator _animator;
    public AnimationClip _destroyClip;
    [SerializeField] private float _clipTime;
    public void SetTriggerDestroy()
    {
        _clipTime = _destroyClip.length;
        Invoke("SetInvisible", _destroyClip.length); // add nameof
        
        _animator.SetTrigger("Destroy");
    }
    public void SetInvisible()
    {
        gameObject.SetActive(false);
    }
}
