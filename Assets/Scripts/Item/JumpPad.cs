using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 100f; // 슈퍼 점프 힘

    private void OnCollisionEnter(Collision collision)
    {
        // 플레이어 태그 확인
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // 기존 Y 속도를 제거한 후 위쪽으로 Impulse 힘을 가함
                Vector3 velocity = rb.velocity;
                velocity.y = 0;
                rb.velocity = velocity;

                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
