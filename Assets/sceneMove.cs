using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneMove : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneMove(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SceneClose(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
    }
}
