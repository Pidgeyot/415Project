using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    //This script must be attached to the end game zone

    //Declaring variables
    bool crossedBoundary;
    GameObject WinText; 
    GameObject Rain; 
    
  
    void Start() {
        WinText = GameObject.Find("WinText");
        WinText.SetActive(false); 
        if(Random.Range(0, 10) <= 2){
         GameObject.Find("Turtle").GetComponent<PlayerMovement>().speed = 12.5f;
         GameObject.Find("Directional Light").GetComponent<Light>().color = new Color32(157, 157, 246, 255); 
        }else{
         GameObject.Find("Rain Overlay").SetActive(false); 
        }
        

    }          
    public void OnCollisionEnter(Collision other)
    {
        //Telling game to actiavte boolean
        if (other.gameObject.tag == "Turtle")
        {
            Debug.Log("Turtle has reached ocean!");
            if (GameObject.Find("GameManager").GetComponent<CollectCounter>().counter == 7)
            {
                WinText.SetActive(true);
                GameObject.Find("Turtle").GetComponent<PlayerMovement>().enabled = false;
            }else if(GameObject.Find("GameManager").GetComponent<CollectCounter>().counter > 7){
                WinText.SetActive(true);
                GameObject.Find("Turtle").GetComponent<PlayerMovement>().enabled = false;
                //confetti or smth? idk
                if(GameObject.Find("GameManager").GetComponent<CollectCounter>().counter == 10){
                    //extra special congratulations
                }
            }
        }
    }
}
