using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private int old_score , new_score;
    void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        old_score = int.Parse(score.text);
        new_score  = old_score + 5;
        score.text = new_score.ToString();
    }
    /*
    void OnCollisionExit(Collision other){

    }*/
}
