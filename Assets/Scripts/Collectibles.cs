using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
public int hit = 0;

void OnCollisionEnter(Collision other){
  if (other.gameObject.tag == "Turtle"){ 
    hit++;
    if (hit == 1){
    gameObject.GetComponent<Collider>().enabled = false;
    gameObject.GetComponent<MeshRenderer>().enabled = false;
    GameObject.Find("GameManager").GetComponent<CollectCounter>().increaseCount();
    }
  }       
 }
   
}

