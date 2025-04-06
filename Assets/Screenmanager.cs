using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screenmanager : MonoBehaviour
{
    public void Sceneloader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}