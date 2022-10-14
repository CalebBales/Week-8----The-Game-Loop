using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisAndThat : MonoBehaviour
{
    [SerializeField] GameObject blueCube, redCube, door;

    bool isRedCubeDetected, isBlueCubeDeteced, areBothCubesDetected;

    // DIRECTIONS: This script is missing a crucial "if statement" in the Update() method.
    // Nothing in Update() needs to change, but something must be added...
    //
    // The "if statements" in OnTriggerEnter() also need to be fixed.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Added a if statement to set areBothCubesDetected to true if they both were
        if (isBlueCubeDeteced && isRedCubeDetected){
            areBothCubesDetected = true;
        }

        if (areBothCubesDetected)
        {
            door.GetComponent<MoveToLocation>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Changed the order of blue and red if statements since red made it to the zone first
        // Also added == red/blueCube to check if objects were in there
        if (other.gameObject == redCube)
        {
           isRedCubeDetected = true;
        }

        if (other.gameObject == blueCube)
        {
           isBlueCubeDeteced = true;
        }
    }
}
