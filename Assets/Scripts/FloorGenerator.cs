using UnityEngine;

public class FloorMovement : MonoBehaviour
{

    public GameObject floorPrefab;
    public int generationRate = 100;

    private int timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void FixedUpdate()
    {
        timer++;
        if(timer >= generationRate)
        {
            timer = 0;
            GameObject newFloor = Instantiate(floorPrefab, new Vector2(floorPrefab.transform.position.x, floorPrefab.transform.position.y), floorPrefab.transform.rotation);
            Destroy(newFloor, 5f);
        }
    }
}
