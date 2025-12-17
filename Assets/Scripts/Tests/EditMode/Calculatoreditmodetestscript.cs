using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Calculatoreditmodetestscript
{
    // A Test behaves as an ordinary method
    [Test]
    public void CalculatoreditmodetestscriptSimplePasses()
    {
        EditorCalculator calculator = new EditorCalculator();

        int actual = calculator.Sub(300, 500);
        int actual2 = calculator.Div(20, 5);


        Assert.AreEqual(-200, actual, "subtracting didnt produce expected result");
        Assert.AreEqual(4, actual2, "dividing didnt produce expected result");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CalculatoreditmodetestscriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
