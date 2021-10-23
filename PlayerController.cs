using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10;

    //Indicates the player boundaries of the game
    public float boundary= 10;
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime* speed);
        //These two if statements defines the boundaries of the player
        if(transform.position.x < -11){
            transform.position = new Vector3(boundary*-1, transform.position.y, transform.position.z);
        }
        if(transform.position.x > 11){

            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }
        
        if (Input.GetKeyDown(KeyCode.Space)){

            //Launch a projectile from the player!
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }
        

        
    }
}
