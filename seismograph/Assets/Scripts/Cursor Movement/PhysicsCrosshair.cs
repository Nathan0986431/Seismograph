using UnityEngine;

public class PhysicsCrosshair : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        // rb.AddForce(movementDirection * movementSpeed * Time.deltaTime);
        rb.linearVelocity = movementDirection * movementSpeed *Time.deltaTime;
    }
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

 
}
