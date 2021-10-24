using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If an object comes into the top or lower boundaries, deestroy that object - and also end the game in a debug log
        if (transform.position.z > topBound){

            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound){
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
