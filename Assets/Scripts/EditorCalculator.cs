using UnityEngine;

public class EditorCalculator : MonoBehaviour
{
   public int Sub(int Num1, int Num2)
    {
        return Num1 - Num2;
    }

    public int Div(int Num1, int Num2)
    {
        if (Num2 == 0)
        {
            Debug.LogError("dividing by zero is illegal");
            return 0;
        }

        return Num1 / Num2;
    }

    public int Mult(int Num1, int Num2)
    {
        return Num1 * Num2;
    }

    public float PI()
    {
        return Mathf.PI;
    }
}
