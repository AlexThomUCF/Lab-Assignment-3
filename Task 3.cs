using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int X = 0;

    public void CalculateBills()
    {
        int[] bills = { 100, 50, 20, 10, 5, 1 };
        
        int[] billCount = new int[bills.Length];
        
        for (int i = 0; i < bills.Length; i++)
        {
            billCount[i] = X / bills[i];
            X %= bills[i];
        }

        for (int i = 0; i < bills.Length; i++)
        {
            if (billCount[i] > 0)
            {
                Debug.Log(billCount[i] + " x $" + bills[i] + " bill(s)");
            }
        }
    }

    public void Start()
    {
        if (X < 0)
        {
            Debug.LogError("Amount must be a non-negative integer.");
            return;
        }

        CalculateBills();
    }
}
