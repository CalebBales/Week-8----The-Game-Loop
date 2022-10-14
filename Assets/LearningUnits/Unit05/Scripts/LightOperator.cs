using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOperator : MonoBehaviour
{
    [SerializeField] GameObject redCube, blueCube;
    [SerializeField] Light pointLight;

    bool isRedCubeDetected, isBlueCubeDeteced;

    // DIRECTIONS: We want the light to turn on when ONLY the red cube is in the trigger zone
    // You only need to make additions to the code in the Update() method;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checked for redCube being in the trigger and used a negate for if blueCube is in the trigger so evaluates to true if blueCube is not inside
        // Then the else just makes sure it stays turned off otherwise
        if (isRedCubeDetected && !isBlueCubeDeteced){
            pointLight.enabled = true;
        }

        else{
            pointLight.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == blueCube)
        {
            isBlueCubeDeteced = true;
        }

        if (other.gameObject == redCube)
        {
            isRedCubeDetected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == blueCube)
        {
            isBlueCubeDeteced = false;
        }

        if (other.gameObject == redCube)
        {
            isRedCubeDetected = false;
        }
    }
}
