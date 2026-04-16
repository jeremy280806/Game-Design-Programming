using UnityEngine;

<<<<<<< Updated upstream
public class Player : MonoBehaviour {   
=======
public class Player : MonoBehaviour{   
>>>>>>> Stashed changes
    private Animator animator;
    public Rigidbody2D rb;
    public float jumpHeight = 7f;
    public float moveSpeed = 5f;
    private float movement; 
    private bool isGround; 
    private bool facingRight;

    public Transform groundCheckPoint;
    public float groundCheckRadius = .2f;
    public LayerMask whatIsGround;

    public GameObject arrowPrefab;
    public Transform spawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        isGround = true;
        facingRight = true;
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
       movement = Input.GetAxis("Horizontal");

       if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
         }
        Collider2D collInfo = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

        if(collInfo){
            isGround = true;
<<<<<<< Updated upstream
=======
        }

        Flip();
        PlayRunAnimation();   

        if(Input.GetMouseButtonDown(1)){
            animator.SetTrigger("Fire");
>>>>>>> Stashed changes
        }

        Flip();
        PlayRunAnimation();   
    }
    private void FixedUpdate(){
        transform.position += new Vector3(movement * moveSpeed, 0f, 0f) * Time.fixedDeltaTime;
    }

<<<<<<< Updated upstream
=======
    public void FireArrow(){
        Instantiate(arrowPrefab, spawnPosition.position, Quaternion.identity);
    }

>>>>>>> Stashed changes
    void PlayRunAnimation(){
        if(Mathf.Abs(movement) > 0f){
            animator.SetFloat("Run", 1f);   
        }
        else if(movement < 0.1f){
            animator.SetFloat("Run", 0f);
        }
    } 

    void Flip(){
        if(movement < 0f && facingRight == true){
            transform.eulerAngles = new Vector3(0f, -180f, 0f);
            facingRight = false;    
        }
        else if(movement > 0f && facingRight == false){
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            facingRight = true; 
        }
    }

    void Jump() {
        if(isGround == true) {
            Vector2 velocity = rb.linearVelocity;
            velocity.y = jumpHeight;
            rb.linearVelocity = velocity;
            isGround = false;
<<<<<<< Updated upstream
            animator.SetBool
=======
            animator.SetBool("Jump", true);
>>>>>>> Stashed changes
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Ground") {
            animator.SetBool("Jump", false);
        }
    }
    private void OnDrawGizmosSelected() {
        if(groundCheckPoint == null) {
            return;
        }
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheckPoint.position, groundCheckRadius);
    }
}