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
        if (areBothCubesDetected)
        {
            door.GetComponent<MoveToLocation>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if (other.gameObject something something)
        // {
        //    isBlueCubeDeteced = true;
        // }

        // if (other.gameObject something something)
        // {
        //    isRedCubeDetected = true;
        // }
    }
}
