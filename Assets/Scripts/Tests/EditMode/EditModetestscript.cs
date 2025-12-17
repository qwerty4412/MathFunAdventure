using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditModetestscript
{
    // A Test behaves as an ordinary method
    [Test]
    public void EditModetestscriptSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator EditModetestscriptWithEnumeratorPasses()
    {
        var gameObject = new GameObject("TestGameobject");
        Assert.AreEqual("TestGameobject", gameObject.name);
        yield return null;
    }
}
