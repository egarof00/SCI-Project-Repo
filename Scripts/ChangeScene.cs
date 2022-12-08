using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    public void ChangeSceneToHomescreen()
    {
        SceneManager.LoadScene("Homescreen");
    }
    
    public void ChangeSceneToProfile()
    {
        SceneManager.LoadScene("ProfilePage");
    }
    //FIXME: Name
    public void ChangeSceneToLeaderBoard()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ChangeSceneToTaskPage()
    {
        SceneManager.LoadScene("Task Page");
    }
    
    public void ChangeSceneToTaskDetails()
    {
        SceneManager.LoadScene("TaskDetails");
    }
    
    
}
