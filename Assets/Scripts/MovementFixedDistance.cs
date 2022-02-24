using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFixedDistance : MonoBehaviour
{
    public float movementSpeed = 2;
    public float jumpVelocity = 2;
    public float verticalMovement;
    public float horizontalMovement;

    public Vector3 targetLocation;
    public Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake() {
    playerPos = transform.position;
    targetLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {     

        verticalMovement = Input.GetAxis("Jump");
        horizontalMovement = Input.GetAxis("Horizontal");
        if(horizontalMovement > 0){
            targetLocation[0] = transform.position[0] + 4;
        }
        if(horizontalMovement < 0){
            targetLocation[0] = transform.position[0] - 4;
            }

    }
    void FixedUpdate(){
        

        float step =  movementSpeed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, targetLocation, step);
        Debug.Log("target" + targetLocation);
        
        transform.position += new Vector3(0, (verticalMovement), 0) * Time.deltaTime * jumpVelocity;
    }

      //Dynamic Rigidbody2d liikkuu simulaationa. Painovoima ja force vaikuttavat siihen loputtomana massalla. Se collidea kaikkien objectien kanssa
    //Kinematic liikkuu simulaationa mutta vain käyttäjän alla. Painovoima ja force ei vaikuta siihen. Collaidaa objectien kanssa vain scriptillä.
    //Static ei liiku simulaationa. Jos objecti collaidaa sen kanssa se ei liiku.
}