using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void Button_Start()
   {
        Debug.Log("Start Button Press");
        SceneManager.LoadScene(1);
   }

   public void Button_Quit()
   {
        Debug.Log("Quit Button Press");
        Application.Quit();
   }
}
