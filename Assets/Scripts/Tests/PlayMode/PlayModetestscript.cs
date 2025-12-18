using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class PlayModetestscript
{
    // A Test behaves as an ordinary method
    [Test]
    public void PlayModetestscriptSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayModetestscriptWithEnumeratorPasses()
    {
        SceneManager.LoadScene("Level1");

        var playerObject = GameObject.FindGameObjectWithTag("Player");
        Assert.IsNotNull(playerObject);
        yield return null;
    }
}
