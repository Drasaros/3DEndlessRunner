using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

     public int speed = 5;
     public Rigidbody rb;
     float Dirx;
     private void Update()
     {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Dirx = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(Dirx, rb.velocity.y);

     }
     private void OnTriggerExit(Collider other)
     {
       
        if (other.gameObject.CompareTag("Platform"))
        {
            print("false");
            other.gameObject.SetActive(false);

        }
     }

    

    


    
}
