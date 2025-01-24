using UnityEngine;

public class Task2 : MonoBehaviour
{
    public float X = 0.0f;
    public int Y = 0;

    public float CalculateWholesaleCost()
    {
        float discountedPrice = X * 0.60f;

        float shippingCost = 3 + (0.75f * (Y - 1));

        float totalWholesaleCost = (discountedPrice * Y) + shippingCost;

        return totalWholesaleCost;
    }

    public float CalculateProfit()
    {
        float sellingPrice = X;

        float totalRevenue = sellingPrice * Y;

        float totalWholesaleCost = CalculateWholesaleCost();

        float profit = totalRevenue - totalWholesaleCost;

        return profit;
    }


    public void Start()
    {
        Debug.Log("Wholesale Cost: $" + CalculateWholesaleCost());
        Debug.Log("Profit (before operational costs): $" + CalculateProfit());
    }
}