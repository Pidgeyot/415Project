using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCounter : MonoBehaviour
{
    public int counter = 0;
    public int totalCount = 7;
    private float timer = 0.0f;
    public GameObject FishEgg;
    private bool lock1 = false;
    private bool lock2 = false;
    private bool lock3 = false;
    

    public void increaseCount(){
        counter++; 
        GameObject.Find("EggCounter").GetComponent<Text>().text = "Eggs collected: " + counter + "/" + totalCount;
        Debug.Log("count = " + counter);
    }
    
    public void ResetCounter(){
        counter = 0; 
        GameObject.Find("EggCounter").GetComponent<Text>().text = "Eggs collected: " + counter + "/7";
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Random.InitState(System.DateTime.Now.Millisecond);
        //at 5 seconds
        if (timer >= 5 && lock1 == false){    
            if (counter >= Random.Range(0, 2)){
            Debug.Log("first special egg spawning");
            Instantiate(FishEgg, new Vector3(-16.0f, 2.0f, -36.5f), Quaternion.identity);
            totalCount++;
            GameObject.Find("EggCounter").GetComponent<Text>().text = "Eggs collected: " + counter + "/" + totalCount;
            lock1 = true;
            }else {
            lock1 = true; 
            }
            
        }
        
        //at 10 seconds
        if (timer >= 10 && lock2 == false){
            if(counter >= Random.Range(0, 5)){  
            Debug.Log("second special egg spawning");
            Instantiate(FishEgg, new Vector3(5.5f, 2.0f, -9.0f), Quaternion.identity);
            totalCount++;
            GameObject.Find("EggCounter").GetComponent<Text>().text = "Eggs collected: " + counter + "/" + totalCount;
            lock2 = true;
            }else {
            lock2 = true; 
            }
        }

        //at 15 seconds
        if (timer >= 15 && lock3 == false){
            if(counter >= Random.Range(0, 9)){
            Debug.Log("third special egg spawning");
            Instantiate(FishEgg, new Vector3(-43.0f, 2.0f, -17.0f), Quaternion.identity);
            totalCount++;
            GameObject.Find("EggCounter").GetComponent<Text>().text = "Eggs collected: " + counter + "/" + totalCount;
            lock3 = true;
            }else {
            lock3 = true; 
            }
        }
        
    }

    
}
