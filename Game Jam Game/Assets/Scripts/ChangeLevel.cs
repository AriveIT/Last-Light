using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public void LoadLevel (string levelName) 
    {
        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }
}
