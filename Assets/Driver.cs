using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class D : MonoBehaviour
{
    [SerializeField] float steerSpeed = 50;
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float boostSpeed = 25;
    [SerializeField] float slowSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float movementSpeed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, movementSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
      
       if(other.tag == "BoostUp"){
            moveSpeed = boostSpeed;
      //      float boostedSpeed = moveSpeed + boostSpeed;
      //      moveSpeed = boostedSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {

        moveSpeed = slowSpeed;

       //     float slowedSpeed = moveSpeed - slowSpeed;
       //     moveSpeed = slowedSpeed;
        }
        
}

