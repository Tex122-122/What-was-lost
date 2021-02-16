using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SimpleMetalDetector : MonoBehaviour
{
    //Distance detection
    public Transform target;
    private float distance;
    //Score counting
    public Text myText;
    private int score = 0;
    void Update()
    {
        //tracks distance between player and object, triggering a Collect when the player walks over the object
        distance = Vector3.Distance(transform.position, target.position);
        print("distance = " + distance);
        myText.text = score.ToString() + "   " + (Mathf.Round(distance)).ToString();
        if (distance < 2)
        {
            Collect();
        }
    }
    void Collect()
    {
        ++score;
        
        //Randomize location
        Vector3 pos = transform.position;

        pos.x = Random.Range(-45.0f, 45.0f);
        pos.y = 0;
        pos.z = Random.Range(-45.0f, 45.0f);

        transform.position = pos;
    }
}
