using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    private Rigidbody2D rb;

    [SerializeField] private float speed = 90;

    private SpriteRenderer spriteRenderer;

    private bool isFacingRight;

    private Animator anim;


    public Joystick joystick;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {

        //horizontal = joystick.Horizontal;
        horizontal = Input.GetAxisRaw("Horizontal");
        
        vertical = Input.GetAxisRaw("Vertical");
        

        
        rb.velocity = new Vector2(horizontal * speed * Time.fixedDeltaTime,

        vertical * speed * Time.fixedDeltaTime);

        
      
        if (horizontal != 0)
        {
            // ѕоворачиваем персонажа в направлении движени€
            if (horizontal < 0 && !isFacingRight || horizontal > 0 && isFacingRight)
            {
                Flip();
            }
        }



        if (horizontal == 0 && vertical == 0)
        {
            anim.SetBool("run_gg", false);
        }
        else
        {
            anim.SetBool("run_gg", true);
        }
    }

    private void Flip()
    {
        
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
