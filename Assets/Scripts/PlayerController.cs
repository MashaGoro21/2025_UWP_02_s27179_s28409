using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
        public float moveSpeed = 5f;
        
        private Rigidbody2D _rb;
        
        private Vector2 _movement;
    
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    
        void Update()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
    
            _movement = _movement.normalized;
        }
    
        void FixedUpdate()
        {
            _rb.MovePosition(_rb.position + _movement * (moveSpeed * Time.fixedDeltaTime));
        }
}
