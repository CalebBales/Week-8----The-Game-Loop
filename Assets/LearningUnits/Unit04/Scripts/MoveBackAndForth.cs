using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    [SerializeField] GameObject destinationObject;

    Vector3 startPosition;
    [SerializeField] float moveSpeed;
    float moveAmount;

    // DIRECTIONS: This script needs to do what MoveToLocation does, but it also needs to move back to it's original location
    // once it arrives, then back and forth infinitely. You will need to add some "if statements" to the Update() method to make it turn around
    // 
    // For this script, you will need to know that a LERP method for Vector3 puts an object at the first position (startPosition in this case)
    // when the LERP amount (moveAmount in this case) is 0 or less, and will put it at the second position (destinationObject.transform.postition in this case)
    // when the LERP amount is 1 or greater. As moveAmount increases from 0 to 1, the object moves from the start position to the 
    // destination position. If moveAmount decreases, it will move in the opposite direction;
    // 
    // You only need to change the line where noted...
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        moveAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Lerp means "linear interpolation"-- it figures out the number between two numbers based 
        // on a percentage from 0 to 1, e.g. Lerp(2,4,.5f) = 3 because 3 is halfway between 2 and 4.
        // Lerp methods can be done to floats, Vectors, and a few other values
        transform.position = Vector3.Lerp(startPosition, destinationObject.transform.position, moveAmount);

        moveAmount += moveSpeed;// We increase the moveAmount based on the moveSpped, and therefore 
        // change the position in the Lerp method above on the next Update() cycle

        // NOTE: Uncomment the four code lines below, and change what is inside the "if statement" to make this work
        // You should NOT write any new lines of code-- just change what is inside the "if statement"

        // Because LERP amounts of 0 and 1 indicate start and end positions respectivelly, checking if the moveAmount is greater/less or equal to them
        // allows the script to continuous flip the movement values from negative to positive infinitely.
        if (moveAmount >= 1 || moveAmount <= 0)
        {
           moveSpeed = -moveSpeed;
        }


    }
}
