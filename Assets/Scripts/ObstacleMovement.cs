using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed = 1f;

    //for the floor* might be using the obstacle prefab position instead, which is why it takes longer to show up
    // Update is called once per frame
    void FixedUpdate()
    {
        //making the pipes drift to the left
        transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - moveSpeed, transform.position.y), 0.1f); //0.1f is how fast we interpolate
    }
}
