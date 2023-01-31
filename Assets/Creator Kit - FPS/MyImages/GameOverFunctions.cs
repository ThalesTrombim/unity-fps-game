using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverFunctions : MonoBehaviour
{
  private void Start()
  {
    Invoke("LoadMenu", 4f);
  }

  private void LoadMenu()
  {
    SceneManager.LoadScene("Menu");
  }
}
