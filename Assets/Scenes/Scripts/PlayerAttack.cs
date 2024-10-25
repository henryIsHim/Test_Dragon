using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float attackCooldown;
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
}
