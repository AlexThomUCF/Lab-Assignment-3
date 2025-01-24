using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public string courseName; 
    public float[] factors = new float[4];
    public bool repeatCourse;
    private float maximumScore = 90.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChallengeScore();
    }

    void ChallengeScore()
    {
        float sum = 0;

        for(int i = 0; i < 4; i++)
        {
            sum += factors[i];
        }
        //Checks if factors equal 90%
        if(sum > maximumScore){
            Debug.Log("Values must equal to 90%");
        }
        //Checks if teacher repreated course is true
        else if(sum <= maximumScore && repeatCourse == true)
        {   
            sum += 10.0f;
            sum /= 10 ;
            Debug.Log(courseName + "Challenge score is " + sum);
        }
        //Checks if teacher repreated course is false
        else if(sum <= maximumScore && repeatCourse == false)
        {
            sum /= 10;
            Debug.Log(courseName + "Challenge score is " + sum);
        }
        
    }
}
