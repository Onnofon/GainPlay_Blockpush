using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string name;

    public void SetScene()
    {
        SceneManager.LoadScene(name);
    }
    
}