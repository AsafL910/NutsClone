using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    public GameObject tree;

    public float invincibilityAfterHitInSeconds = 1f;
    public float turningSpeed = 400f;
    [Tooltip("Max rotation to each side in degrees")]
    public float rotationSpeed = 70f;
    public GameManager gameManager;

    public float rotationSmoothing = 10f;
    public Vector3 movementRotationModifier = Vector3.one;
    public Animator animator;
    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        gameObject.transform.position = tree.transform.position + Vector3.right * tree.GetComponent<CapsuleCollider>().radius;
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        transform.RotateAround(tree.transform.position, Vector3.up, Time.deltaTime * turningSpeed * -input);
        transform.LookAt(tree.transform);
        float rotationAmount = -input * rotationSpeed;
        Quaternion target = transform.rotation * Quaternion.Euler(Mathf.Abs(rotationAmount) * movementRotationModifier.x, rotationAmount * movementRotationModifier.y, rotationAmount * movementRotationModifier.z);
        transform.rotation = Quaternion.Lerp(transform.rotation, target, rotationSmoothing * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Branch"))
        {
            //play hurt animation and sound
            animator.SetBool("isPlayerHit", true);
            gameManager.playerHp--;
            StartCoroutine(ResetHitAnimation());
        }
    }

    private IEnumerator ResetHitAnimation()
    {
        yield return new WaitForSeconds(invincibilityAfterHitInSeconds);
        animator.SetBool("isPlayerHit", false);
    }
}