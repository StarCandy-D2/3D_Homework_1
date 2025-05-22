using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EquipTool : Equip
{

    public float attackRate;
    public bool attacking;
    public float attackDistance;

    [Header("Resource Gathering")]
    public bool doesGatherResources;

    [Header("Combat")]
    public bool doesDealDamage;
    public int damage;

    [Header("Movement Buff")]
    public float jumpBoostAmount = 0f;

    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public override void OnAttackInput()
    {
        if (!attacking)
        {
            attacking = true;
            animator.SetTrigger("Attack");
            Invoke("OnCanAttack", attackRate);
        }
    }
    void OnCanAttack()
    {
        attacking = false;
    }
    public void OnHit()
    {
        Debug.Log("애니메이션 이벤트 OnHit 호출됨");

        // 실제 채집 또는 타격 처리 여기서 수행
        // 예시: Raycast로 맞은 대상에 데미지 전달 등
    }
}
