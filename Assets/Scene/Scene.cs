using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{

    public void LoadScene(string Scene1)
    {
        SceneManager.LoadScene(Scene1);
    }
    
}
