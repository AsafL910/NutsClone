using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    public GameObject tree;
    private Vector3 playerVelocity;
    private Vector3 playerRotation;
    public float turningSpeed = 400f;
    public float rotationSpeed = 100f;

public float deadzone = 0.1f;
    public float rotationSmoothing = 10f;
    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        gameObject.transform.position = tree.transform.position + Vector3.right * (tree.GetComponent<CapsuleCollider>().radius);
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        transform.RotateAround(tree.transform.position,Vector3.up, Time.deltaTime * turningSpeed * -input);
        transform.LookAt(tree.transform);
        Quaternion target = transform.rotation * Quaternion.Euler(0,0, -input * rotationSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation,target, rotationSmoothing * Time.deltaTime);
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, playerVelocity);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, playerRotation);
    }
}

            // playerRotation = new Vector3(gameObject.transform.position.x - tree.transform.position.x, 0f, gameObject.transform.position.z - tree.transform.position.z);
            // playerVelocity = new Vector3(-playerRotation.z, 0f, playerRotation.x);
        // if (input != 0) {
        //     rb.position += playerVelocity;
        // }
        // else {
        //     rb.velocity = Vector3.zero;
        // }