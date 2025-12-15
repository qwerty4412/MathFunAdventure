using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
   public void StartGame()
   {
    SceneManager.LoadSceneAsync("Level1");

   }
}
