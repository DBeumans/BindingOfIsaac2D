using UnityEngine;
using System.Collections;

public class Player_Shooting_Animation : MonoBehaviour {


    Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayAnimation(string direction)
    {
        switch(direction)
        {
            case "Left":
                _animator.SetBool("Shoot_Left", true);
                _animator.SetBool("Shoot_Left", false);
                break;
            case "Right":
                _animator.SetBool("Shoot_Right", true);
                _animator.SetBool("Shoot_Right", false);
                break;
            case "Up":
                _animator.SetBool("Shoot_Up", true);
                _animator.SetBool("Shoot_Up", false);
                break;
            case "Down":
                _animator.SetBool("Shoot_Down", true);
                _animator.SetBool("Shoot_Down", false);
                break;
        }
    }
}
