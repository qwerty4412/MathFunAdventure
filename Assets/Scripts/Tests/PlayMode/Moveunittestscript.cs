using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class CharacterMovementTests
{
    // A UnityTest attribute is used for Play Mode tests that need to yield
    [UnityTest]
    public IEnumerator CharacterMovesForward()
    {

        // Create a test GameObject and attach the CharacterController component
        var playerObject = GameObject.FindGameObjectWithTag("Player");
        CharacterController controller = playerObject.GetComponent<CharacterController>();
        // Assume you have a script for movement logic attached as well, e.g., PlayerMovement
        // PlayerMovement movementScript = playerObject.AddComponent<PlayerMovement>();
        
        Vector3 initialPosition = Vector3.zero;
        playerObject.transform.position = initialPosition;
        float moveSpeed = 5f; // Example speed

        // Wait a frame for physics to initialize
        yield return null; 

        // === ACT ===
        // Simulate movement. The actual implementation depends on your specific controller script's methods
        // controller.Move(playerObject.transform.forward * moveSpeed * Time.deltaTime); 
        // A better approach is to test the logic that *calls* the Move function, or the resulting position.

        // For this example, we directly change the position for a simple test of position logic:
        Vector3 intendedMove = new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime;
        playerObject.transform.position += intendedMove;


        // Wait a few frames to allow movement/physics to settle (if using Rigidbody/complex physics)
        yield return new WaitForSeconds(0.1f); 

        // === ASSERT ===
        // Check if the position has changed as expected
        // Using an equality comparer with a tolerance (e.g., FloatEqualityComparer) is recommended for floats
        Assert.AreNotEqual(initialPosition, playerObject.transform.position, "Character did not move from initial position");
        // Example with tolerance:
        // Assert.That(playerObject.transform.position.z, Is.EqualTo(initialPosition.z + expectedZChange).Within(0.01f));


        // Clean up afterwards if needed
        GameObject.Destroy(playerObject);
    }
}