 using UnityEngine;
 using System.Collections;
 public class PlayerMovement : MonoBehaviour 
 {
    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y);
    }
}