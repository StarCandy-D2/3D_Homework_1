using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 100f; // ���� ���� ��

    private void OnCollisionEnter(Collision collision)
    {
        // �÷��̾� �±� Ȯ��
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // ���� Y �ӵ��� ������ �� �������� Impulse ���� ����
                Vector3 velocity = rb.velocity;
                velocity.y = 0;
                rb.velocity = velocity;

                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
