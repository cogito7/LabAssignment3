using UnityEngine;

public class Task2 : MonoBehaviour
{
    public double originalPriceX;
    public double numberOfCopiesY;
    public bool isBookstore;

    private double bookCost;
    private double shippingCost;
    private double totalCost;
    private double profit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //negative numbers and zero are invalid entries, because businesses don't work that way
        if (originalPriceX > 0 && numberOfCopiesY > 0)
        {
            CalculateBookCost();
            CalculateShippingCost();
            CalculateTotalCost();
            CalculateProfit();
        } else
        {
            InvalidEntry();
        }
    }

    //calculates the cost of books, and applies a discount if a book store is placing the order
    void CalculateBookCost()
    {
        bookCost = originalPriceX * numberOfCopiesY;
        if (isBookstore)
        {
            bookCost = bookCost * 0.60;
        }
        Debug.Log("The cost of the books is $" + bookCost.ToString("F2") + ".");
    }

    //calculates the shipping cost at a rate of $3 for the first book and $0.75 for each book after the first
    void CalculateShippingCost()
    {
        shippingCost = (3 * (numberOfCopiesY / numberOfCopiesY)) + (0.75 * (numberOfCopiesY - 1));
        Debug.Log("The shipping cost is $" + shippingCost.ToString("F2") + ".");
    }

    //calculates total order cost
    void CalculateTotalCost()
    {
        totalCost = bookCost + shippingCost;
        Debug.Log("Your total cost is $" + totalCost.ToString("F2") + ".");
    }

    //only runs if a book store is placing the order
    //calculates potential profits by subtracting total order cost from undiscounted cost of books
    void CalculateProfit()
    {
        if (isBookstore)
        {
            profit = (bookCost / 0.6) - totalCost;
            Debug.Log("Your potential profit will be $" + profit.ToString("F2"));
        }
    }

    //returns 0 if the entry is invalid
    void InvalidEntry()
    {
        Debug.Log("The cost of the books is $0.00.");
        Debug.Log("The cost of shipping is $0.00.");
        Debug.Log("The total cost is $0.00");
        if (isBookstore)
        {
            Debug.Log("Your potential profit will be $0.00.");

        }
    }
}