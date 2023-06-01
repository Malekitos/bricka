using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ainasParslegsana : MonoBehaviour {

    public void apturet()
    {
        Application.Quit();
    }

    public void uzSceneSpelet()
    {
        SceneManager.LoadScene("Pilseta", LoadSceneMode.Single);
    }
    public void uzSceneSakums()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
}

