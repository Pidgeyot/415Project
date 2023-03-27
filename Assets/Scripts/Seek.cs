using UnityEngine;

public class Seek : MonoBehaviour
{
    // Reference to the target object
    public GameObject target;

    // List of checkpoint objects
    public GameObject[] checkpoints;

    // Speed at which the object moves towards the target
    public float speed = 5.0f;

    // The index of the current checkpoint
    private int currentCheckpointIndex = 0;

    void Update()
    {
        // If the object has reached the target, do nothing
        if (Vector3.Distance(transform.position, target.transform.position) < 0.1f)
        {
            return;
        }

        // If the object has reached the current checkpoint, move to the next checkpoint
        if (Vector3.Distance(transform.position, checkpoints[currentCheckpointIndex].transform.position) < 0.1f)
        {
            currentCheckpointIndex++;
        }

        // If there are no more checkpoints, move towards the target
        if (currentCheckpointIndex >= checkpoints.Length)
        {
            Vector3 direction = (target.transform.position - transform.position).normalized;
            transform.position += direction * Time.deltaTime * speed;
        }
        // Otherwise, move towards the next checkpoint
        else
        {
            Vector3 direction = (checkpoints[currentCheckpointIndex].transform.position - transform.position).normalized;
            transform.position += direction * Time.deltaTime * speed;
        }
    }
}
