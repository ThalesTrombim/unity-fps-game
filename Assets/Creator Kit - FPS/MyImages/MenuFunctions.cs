using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
  public void StartGame()
  {
    SceneManager.LoadScene("First level");
  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
