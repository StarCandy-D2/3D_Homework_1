using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 10f; // 이동 거리
    public float moveSpeed = 2f;    // 이동 속도

    private Vector3 startPos;
    private bool movingRight = true;
    private Vector3 lastPosition;

    private List<Rigidbody> riders = new List<Rigidbody>();

    void Start()
    {
        startPos = transform.position;
        lastPosition = transform.position;
    }

    void Update()
    {
        float moveStep = moveSpeed * Time.deltaTime;

        if (movingRight)
        {
            transform.position += Vector3.right * moveStep;
            if (transform.position.x >= startPos.x + moveDistance)
                movingRight = false;
        }
        else
        {
            transform.position += Vector3.left * moveStep;
            if (transform.position.x <= startPos.x - moveDistance)
                movingRight = true;
        }
    }

    void FixedUpdate()
    {
        Vector3 delta = transform.position - lastPosition;

        foreach (var rb in riders)
        {
            if (rb != null)
                rb.MovePosition(rb.position + delta);
        }

        lastPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null && !riders.Contains(rb))
                riders.Add(rb);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null && riders.Contains(rb))
                riders.Remove(rb);
        }
    }
}

