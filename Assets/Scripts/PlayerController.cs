using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    public GameObject tree;
    public float turningSpeed = 400f;
    [Tooltip("Max rotation to each side in degrees")]
    public float rotationSpeed = 70f;
    public GameManager gameManager;

    public float rotationSmoothing = 10f;
    
    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        gameObject.transform.position = tree.transform.position + Vector3.right * tree.GetComponent<CapsuleCollider>().radius;
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        transform.RotateAround(tree.transform.position,Vector3.up, Time.deltaTime * turningSpeed * -input);
        transform.LookAt(tree.transform);
        Quaternion target = transform.rotation * Quaternion.Euler(0,0, -input * rotationSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation,target, rotationSmoothing * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Branch"))
        {
            //play hurt animation and sound
            gameManager.playerHp--;
        }
    }
}