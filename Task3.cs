using Unity.VisualScripting;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int paidDollarsX;
    private int hundreds;
    private int fifties;
    private int twenties;
    private int tens;
    private int fives;
    private int ones;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //calculate how many of each dollar bill then return remainder until only "ones" remain.
        hundreds = paidDollarsX / 100;
        paidDollarsX %= 100;

        fifties = paidDollarsX / 50;
        paidDollarsX %= 50;

        twenties = paidDollarsX / 20;
        paidDollarsX %= 20;

        tens = paidDollarsX / 10;
        paidDollarsX %= 10;

        fives = paidDollarsX / 5;
        paidDollarsX %= 5;

        ones = paidDollarsX;

        //print to the console how many of each dollar amount for each dollar bill type.
        if (hundreds > 0)
        {
            Debug.Log("$100 bills: " + hundreds);
        }

        if (fifties > 0)
        {
            Debug.Log("$50 bills: " + fifties);
        }

        if (twenties > 0)
        {
            Debug.Log("20 bills: " + twenties);
        }

        if (tens > 0)
        {
            Debug.Log("10 bills: " + tens);
        }

        if (fives > 0)
        {
            Debug.Log("5 bills: " + fives);
        }

        if (ones > 0)
        {
            Debug.Log("1 bills: " + ones);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
