using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, InputSystem_Actions.IPlayer2Actions
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rayLength = 0.5f;
    [SerializeField] private LayerMask ground;
    public InputSystem_Actions action;
    private Rigidbody2D rb;
    private RaycastHit2D hit;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        action = new InputSystem_Actions();
        action.Player2.SetCallbacks(this);
    }
    private void OnEnable()
    {
        action.Enable();
    }
    private void OnDisable()
    {
        action.Disable();
    }
    public bool IsGrounded()
    {
        hit = Physics2D.Raycast(transform.position, rb.gravityScale > 0 ? Vector2.down : Vector2.up, rayLength, ground);
        return hit.collider != null;
    }
    public void OnInvert(InputAction.CallbackContext context)
    {
        if (IsGrounded())
        {
            transform.localScale = new Vector3(transform.localScale.x, -(transform.localScale.y), transform.localScale.z);
            rb.gravityScale = -rb.gravityScale;
        }
    }

    public void OnLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.linearVelocityX = -speed;
        }
    }
    public void OnRight(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        rb.linearVelocityX = speed;
	}

    

    void Update()
    {
        
    }
}
