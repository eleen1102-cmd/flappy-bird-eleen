using UnityEngine;
using TMPro; //needed for text mesh pro library
using UnityEngine.SceneManagement; //to reset the scene 
public class BirdMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    private Rigidbody2D body;
    private PolygonCollider2D polygonCollider;
    private float horizontalInput;
    private Animator anim;

    public TextMeshProUGUI scoreText;

    private int score;

    
    
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

    //score
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ScoreTrigger"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    //resetting the game after loss
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Jump()
    {
        body.linearVelocity = new Vector2(0, jumpPower);
        anim.SetTrigger("jump");
    }
}
