using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EndGame : MonoBehaviour
{
    //This script must be attached to the end game zone

    //Declaring variables
    bool crossedBoundary;
    GameObject WinText; 
  
    void Start() {
        WinText = GameObject.Find("WinText");
        WinText.SetActive(false); 

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
