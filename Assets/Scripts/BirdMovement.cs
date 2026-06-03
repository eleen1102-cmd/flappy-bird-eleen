using UnityEngine;
//NEED TO ADD: 
//animations 
//stop bird from tilting over (or control the tilting since it is actually in flappy bird)
public class BirdMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    private Rigidbody2D body;
    private PolygonCollider2D polygonCollider;
    private float horizontalInput;
    private Animator anim;
    
    
    //awake is called everytime tbe script is loaded
  private void Awake()
    {
        //grab references for rigidbody and animator 
        body = GetComponent<Rigidbody2D>(); //finds rigibody2D and will store it in the body
        polygonCollider = GetComponent<PolygonCollider2D>();
        anim = GetComponent<Animator>();
    }

   
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //idk if i actually need this rn

        if (Input.GetKey(KeyCode.Space))
            Jump();



    }

    private void Jump()
    {
        body.linearVelocity = new Vector2(body.linearVelocityX, jumpPower);
        anim.SetTrigger("jump");
    }
}
