using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMaangement : MonoBehaviour
{ 
    public Button loadGameButton;
    public GameObject optionsMenu;
     public Button optionsButton;
     public Button exitButton;

  private void Update()
  {
   if(Input.GetKeyDown(KeyCode.E))
   {
    loadGameButton.onClick.Invoke();
   }
   
   if(Input.GetKeyDown(KeyCode.T))
   {
    optionsButton.onClick.Invoke();
   }
    if(Input.GetKeyDown(KeyCode.Escape))
   {
    exitButton.onClick.Invoke();
   }
   

  }
  public void LoadScene()
  {
    SceneManager.LoadScene("MainGame");
  }
  
  public void Options()
  {
   optionsMenu.gameObject.SetActive(true);
  }
  public void OptionsExit()
  {
    optionsMenu.gameObject.SetActive(false);
  }
    
   
}

