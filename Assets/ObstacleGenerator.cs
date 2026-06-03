using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int generationRate = 100;

    private int timer;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if(timer >= generationRate)
        {
            timer = 0;                                                      //(prefabs default position)    move the y pos up and down within range
            GameObject newObstacle = Instantiate(obstaclePrefab, new Vector2(obstaclePrefab.transform.position.x, obstaclePrefab.transform.position.y + Random.Range(-2f, 2f)), obstaclePrefab.transform.rotation);
            Destroy(newObstacle, 5f); //destroy after 5 seconds 
        }
    }
}
