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
     public GameObject pauseMenu;
     public GameObject pauseButtonOBJ;
     public Button resumeButton;
     public Button restartButton;
     public Button quitButton;
     public Button pauseButton;
     public Button exitForMain;


  private void Update()
  {
    //To start the story mode
   if(Input.GetKeyDown(KeyCode.E))
   {
    loadGameButton.onClick.Invoke();
   }
    //To open the options menu
   if(Input.GetKeyDown(KeyCode.T))
   {
    optionsButton.onClick.Invoke();
   }
   //To pause the game
    if(Input.GetKeyDown(KeyCode.Escape))
   {
    pauseButton.onClick.Invoke();
   }
   //To resume the game
    if(Input.GetKeyDown(KeyCode.R))
   {
    resumeButton.onClick.Invoke();
   }
   //To restart the game
   if(Input.GetKeyDown(KeyCode.M))
   {
    restartButton.onClick.Invoke();
   }
   //To kill the options menu 
   if(Input.GetKeyDown(KeyCode.A))
   {
    exitButton.onClick.Invoke();
   }   
   //To quit the game
   if(Input.GetKeyDown(KeyCode.B))
   {
    quitButton.onClick.Invoke();
   }
   //To open the options menu in the main level
   if(Input.GetKeyDown(KeyCode.P))
   {
    optionsButton.onClick.Invoke();
   }
   //To kill the options menu in the main level
    if(Input.GetKeyDown(KeyCode.K))
   {
    exitForMain.onClick.Invoke();
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
  //Pause Menu and Control
    public void PauseMenu()
    {
      Time.timeScale = 0f;
      pauseMenu.gameObject.SetActive(true);
      pauseButtonOBJ.gameObject.SetActive(false);
    }
    public void ResumeButton()
    {
     Time.timeScale = 1f;
     pauseMenu.gameObject.SetActive(false);
     pauseButtonOBJ.gameObject.SetActive(true);
    }
    public void RestartButton()
    {
      SceneManager.LoadScene("MainGame");
    }
    public void Exit()
    {
      SceneManager.LoadScene("Lobby");
    }
    public void ExitForMain()
    {
      optionsMenu.gameObject.SetActive(false);
    }

   
}

