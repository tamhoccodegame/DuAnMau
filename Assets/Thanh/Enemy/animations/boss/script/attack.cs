using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private float range;
    [SerializeField] private float _collioderDistand;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D _boxCollider;
    [SerializeField] private LayerMask _playerlayer;
    private float cooldownTimer = Mathf.Infinity;

    private Animator anim;
    private playerhealth playerHealth;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (PlayerInSight())
        {
            if (cooldownTimer >= attackCooldown)
            {
                cooldownTimer = 0;
                anim.SetTrigger("meleeAttack");
            }
        }
    }

    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(_boxCollider.bounds.center + transform.right * range * transform.localScale.x * _collioderDistand,
            new Vector3(_boxCollider.bounds.size.x *range, _boxCollider.bounds.size.y,_boxCollider.bounds.size.z),
             0, Vector2.left,0,_playerlayer);
        if(hit.collider != null)
        {
            playerHealth = hit.transform.GetComponent<playerhealth>();
        }

        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(_boxCollider.bounds.center + transform.right * range * transform.localScale.x * _collioderDistand,
            new Vector3(_boxCollider.bounds.size.x * range, _boxCollider.bounds.size.y, _boxCollider.bounds.size.z));
    }

    private void DamagePlayer()
    {
        if (PlayerInSight())
        {
            playerHealth.TakeDamage(damage);
        }
    }




}
