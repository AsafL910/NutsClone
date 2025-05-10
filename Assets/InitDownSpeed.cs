using UnityEngine;

public class InitDownSpeed : MonoBehaviour
{
    public Rigidbody rb;

    void Update()
    {
        rb.velocity = Vector3.down * GameManager.Instance.climbSpeed;
    }
}