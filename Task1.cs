using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using System;


public class Task1 : MonoBehaviour
{
    public string courseName;
    [Range(1, 10)] public int numModules;
    [Range(1, 10)] public int numReadings;
    [Range(1, 10)] public int numQuizzes;
    [Range(1, 10)] public int numAssignments;
    public bool isInstructorNonRookie;
    private double challengeScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //calculates each factor percentage
        double modulePoints = ((double) numModules / 10) * 0.15;
        challengeScore += modulePoints;

        double readingsPoints = ((double) numReadings / 10) * 0.30;
        challengeScore += readingsPoints;

        double quizzesPoints = ((double) numQuizzes / 10) * 0.15;
        challengeScore += quizzesPoints;

        double assignmentsPoints = ((double)numAssignments / 10) * 0.30;
        challengeScore += assignmentsPoints;

        //adds points for experienced teacher
        if (isInstructorNonRookie == true)
        {
            challengeScore += 0.10;
        }

        //outputs name and challengeScore
        Debug.Log(courseName + " has a difficulty rating of " + challengeScore * 10 + "/10.");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
