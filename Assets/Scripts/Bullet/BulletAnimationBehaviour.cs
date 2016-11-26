using UnityEngine;
using System.Collections;

public class BulletAnimationBehaviour : MonoBehaviour
{

    Animator _animator;
    bool _animationDonePlaying;
    public bool AnimationDonePlaying { get { return _animationDonePlaying; } }
    public bool AnimationIsPlaying { get { return _animationIsPlaying; } }

    bool _animationIsPlaying;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Bullet_Destroyed()
    {
        _animator.SetBool("isDestroyed", true);
        _animationIsPlaying = true;
        StartCoroutine(Check());
    }
    IEnumerator Check()
    {
        while(!_animator.GetCurrentAnimatorStateInfo(0).IsName("Traan_Hit"))
        {
            if (_animator.GetCurrentAnimatorClipInfo(0).Length >= _animator.GetCurrentAnimatorClipInfo(0).Length * _animator.GetCurrentAnimatorStateInfo(0).normalizedTime)
            {
               
            }
            yield return new WaitForSeconds(.70f) ;
        }
        _animationDonePlaying = true;
    }
}
