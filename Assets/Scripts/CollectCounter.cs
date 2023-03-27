using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCounter : MonoBehaviour
{
    public int counter = 0;
    int rd;
    public int[] searcharr = { 0, 0, 0, 0, 0, 0, 0 };
    public List<int> vals;
    

    public void increaseCount(){
        counter++; 
        GameObject.Find("EggCounter").GetComponent<Text>().text = "Eggs collected: " + counter + "/7";
        Debug.Log("count = " + counter);
        rd = Random.Range(0, vals.Count);
        searcharr[counter - 1] = vals[rd];
        vals.RemoveAt(rd);

    }
    
    public void ResetCounter(){
        counter = 0; 
        GameObject.Find("EggCounter").GetComponent<Text>().text = "Eggs collected: " + counter + "/7";
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < 8; i++){
            vals.Add(i);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
