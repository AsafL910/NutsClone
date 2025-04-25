using UnityEngine;

public class Despawn : MonoBehaviour
{
    [SerializeField] private float despawnTime = 5f;

    protected virtual void Start()
    {
        Destroy(gameObject, despawnTime);
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Despawn"))
        {
            Destroy(gameObject);
        }
    }
}
