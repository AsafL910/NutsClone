using UnityEngine;

public class Camera : MonoBehaviour
{
  public Transform target;

public float offset = 0f;
  public float angle = 0f;
  public float distance = 3;

private void Start() {
}
    private void LateUpdate()
    {
            // Update the camera's position based on the player's position and offset
            transform.position = distance*target.position + Vector3.down * offset;

            // Make the camera look at the player's position
            transform.LookAt(target.position + Vector3.up * distance * Mathf.Tan(Mathf.Deg2Rad * angle));
        
    }
}
