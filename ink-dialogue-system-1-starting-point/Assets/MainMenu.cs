using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Play game function//
    public void PlayGame ()
    {
        //It will load the next scene//
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
