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
        Debug.Log("�ִϸ��̼� �̺�Ʈ OnHit ȣ���");

        // ���� ä�� �Ǵ� Ÿ�� ó�� ���⼭ ����
        // ����: Raycast�� ���� ��� ������ ���� ��
    }
}
