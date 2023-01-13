using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnSpeed;
    public float speed;
    public float horizontalInput;
    public float verticalInput;
    public bool gameOver = false;
     
    private bool isOnGround = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput =Input.GetAxis("Horizontal");
        verticalInput =Input.GetAxis("Vertical");
        // transform.Translate(Vector3.right*Time.deltaTime*turnSpeed*horizontalInput);
        transform.Rotate(Vector3.up*Time.deltaTime*turnSpeed*horizontalInput);
        transform.Translate(Vector3.right*Time.deltaTime*turnSpeed*horizontalInput);
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);  
        isOnGround = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Road")){
            isOnGround =true;
        }else if (collision.gameObject.CompareTag("GreyCar")){
            gameOver =true;
            Debug.Log("Game Over!");
            // Destroy(gameObject);
        }else if (collision.gameObject.CompareTag("PurpleCar")){
            gameOver =true;
            Debug.Log("Game Over!");
            // Destroy(gameObject);
        }
    }
}
