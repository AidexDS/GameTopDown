using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class ENEMY : MonoBehaviour
{
public GameObject player;
public float speed;
private float distance;
public float detectionDistance;
    public PlayerMovement playerM;
   //public ItemSpawn drop;
//Enemy details
    public float Health;
    public GameObject loot;

    public AttributPlayer AP;


public Boolean Detection;


    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Health <= 0)
        {
            
        }



        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 directrion = player.transform.position - transform.position;
        directrion.Normalize();
        // Atan2 used for finding angle between two points
        float angle = Mathf.Atan2(directrion.y, directrion.x)* Mathf.Rad2Deg;

        
void Movement(){
     transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, (speed*10 ) * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
}

    if(Detection == true){
        if(distance < detectionDistance){

             Movement();
             //Detection = false;
              


            }
        }else{
              Movement();
        }
    }


    

    

    public void OnDrawGizmos()
    {
        if(Detection){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionDistance);
        }
     }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            AP.takeDamage(10);
        }
    }






}



    
     


    

