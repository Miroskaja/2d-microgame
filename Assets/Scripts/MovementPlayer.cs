 using UnityEngine;
 using System.Collections;
 public class MovementPlayer : MonoBehaviour 
 {
    Rigidbody2D rb;
    [SerializeField] float movementSpeed = 6f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y);
    }

    //Dynamic Rigidbody2d liikkuu simulaationa. Painovoima ja force vaikuttavat siihen loputtomana massalla. Se collidea kaikkien objectien kanssa
    //Kinematic liikkuu simulaationa mutta vain käyttäjän alla. Painovoima ja force ei vaikuta siihen. Collaidaa objectien kanssa vain scriptillä.
    //Static ei liiku simulaationa. Jos objecti collaidaa sen kanssa se ei liiku.
}