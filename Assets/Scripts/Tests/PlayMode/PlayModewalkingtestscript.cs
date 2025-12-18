using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using NUnit.Framework.Internal;


public class PlayModewalkingtestscript
{
    private GameObject testObject;
    private PlayerController controller;
    // A Test behaves as an ordinary method
    [Test]
    public void PlayModewalkingtestscriptSimplePasses()
    {
        
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [SetUp]
    public void Setup()
    {
        testObject = GameObject.Instantiate(new GameObject());
        testObject.AddComponent<CharacterController>();
        controller = testObject.AddComponent<PlayerController>();
    }

    [UnityTest]
    public IEnumerator PlayModeWalkingtestscript()
    {
        yield return new WaitForSeconds(0.1f);

        Assert.IsNotNull(controller.GetComponent<CharacterController>(), "PlayerController has controller attached");
    }

    
    [UnityTest]
    public IEnumerator Movementtest()
    {
        Vector3 position =  controller.transform.position;
        controller.SetMoveInputForTesting(new Vector2(1, 0));
        yield return new WaitForSeconds(0.1f);
        Vector3 newPosition = controller.transform.position;
        Assert.AreNotEqual(newPosition, position, "Movetest passed moved object" + position + "to" + newPosition);
    }

    [TearDown]
    public void TearDown()
    {
        GameObject.Destroy(testObject);
    }
}
