using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float h;    //Contains info on player's horizontal movement
    float v;    //COntains info on player's vertical movement 
    Vector3 moveDirection;    //The var to store player's movement
    [SerializeField] float speed = 3;   //Walking speed
    [SerializeField] Transform aim; //An object for the aim
    [SerializeField] Camera camera; //An objecto to save main camera properties
    Vector3 facingDirection;    //Direction the player is loking at (aim)


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");    //Gets horizontal imput from keyboard and stores it
        v = Input.GetAxis("Vertical");    //Gets horizontal imput from keyboard and stores it
        
        // Stores the value for input in vector
        moveDirection.x = h;    
        moveDirection.y = v;

        transform.position += moveDirection * Time.deltaTime * speed; //Updates position, Time.deltaTime is time between frames

        //Aim movement
        facingDirection = camera.ScreenToWorldPoint(Input.mousePosition) - transform.position;  //Gets the vector difference between mouse and player to get direction
        aim.position = transform.position + facingDirection.normalized;     //The previous vector is normalized and set with player as origin

    }




}
