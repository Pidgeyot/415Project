using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EndGame : MonoBehaviour
{
    //This script must be attached to the end game zone

    //Declaring variables
    bool crossedBoundary;
    GameObject WinText; 
    int gameIteration = 0;
    bool gameOptimize = false;
    Vector3 turtlePosition;

    void Start() {
        WinText = GameObject.Find("WinText");
        WinText.SetActive(false); 
        turtlePosition = GameObject.Find("Turtle").transform.position;
    }          
    public void OnCollisionEnter(Collision other)
    {
        //Telling game to actiavte boolean
        if (other.gameObject.tag == "Turtle")
        {
            Debug.Log("Turtle has reached ocean!");
            if (GameObject.Find("GameManager").GetComponent<CollectCounter>().counter >= 7 && gameOptimize != true)
            {
                Debug.Log("Turtle has reached ocean.....AND WON");
                GameObject.Find("Turtle").transform.position = turtlePosition;
                EggRespawn();
                GameObject.Find("GameManager").GetComponent<CollectCounter>().ResetCounter();
                gameIteration++;
                EggReColor();
            }else if (GameObject.Find("GameManager").GetComponent<CollectCounter>().counter >= 7 && gameOptimize == true){
                WinText.SetActive(true);
                GameObject.Find("Turtle").GetComponent<PlayerMovement>().enabled = false;
            }
            
        }
    }

    public void EggRespawn(){
     GameObject.Find("FishEgg").GetComponent<Collider>().enabled = true;
     GameObject.Find("FishEgg").GetComponent<MeshRenderer>().enabled = true;
     GameObject.Find("FishEgg").GetComponent<Collectibles>().hit = 0;
     GameObject.Find("FishEgg (1)").GetComponent<Collider>().enabled = true;
     GameObject.Find("FishEgg (1)").GetComponent<MeshRenderer>().enabled = true;
     GameObject.Find("FishEgg (1)").GetComponent<Collectibles>().hit = 0;
     GameObject.Find("FishEgg (2)").GetComponent<Collider>().enabled = true;
     GameObject.Find("FishEgg (2)").GetComponent<MeshRenderer>().enabled = true;
     GameObject.Find("FishEgg (2)").GetComponent<Collectibles>().hit = 0;
     GameObject.Find("FishEgg (3)").GetComponent<Collider>().enabled = true;
     GameObject.Find("FishEgg (3)").GetComponent<MeshRenderer>().enabled = true;
     GameObject.Find("FishEgg (3)").GetComponent<Collectibles>().hit = 0;
     GameObject.Find("FishEgg (4)").GetComponent<Collider>().enabled = true;
     GameObject.Find("FishEgg (4)").GetComponent<MeshRenderer>().enabled = true;
     GameObject.Find("FishEgg (4)").GetComponent<Collectibles>().hit = 0;
     GameObject.Find("FishEgg (5)").GetComponent<Collider>().enabled = true;
     GameObject.Find("FishEgg (5)").GetComponent<MeshRenderer>().enabled = true;
     GameObject.Find("FishEgg (5)").GetComponent<Collectibles>().hit = 0;
     GameObject.Find("FishEgg (6)").GetComponent<Collider>().enabled = true;
     GameObject.Find("FishEgg (6)").GetComponent<MeshRenderer>().enabled = true;
     GameObject.Find("FishEgg (6)").GetComponent<Collectibles>().hit = 0;
    }

    public void EggReColor(){
     if(gameIteration == 1){
       GameObject.Find("FishEgg").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
       GameObject.Find("FishEgg (1)").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
       GameObject.Find("FishEgg (2)").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
       GameObject.Find("FishEgg (3)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
       GameObject.Find("FishEgg (4)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
       GameObject.Find("FishEgg (5)").GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
       GameObject.Find("FishEgg (6)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
      }
     if(gameIteration == 2){
       GameObject.Find("FishEgg").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
       GameObject.Find("FishEgg (1)").GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
       GameObject.Find("FishEgg (2)").GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
       GameObject.Find("FishEgg (3)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
       GameObject.Find("FishEgg (4)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
       GameObject.Find("FishEgg (5)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
       GameObject.Find("FishEgg (6)").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
       gameOptimize = true;
      }
    }
}
