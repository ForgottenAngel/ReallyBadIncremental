using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneManager : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Scene1()
    {
        SceneManager.LoadScene("InvScene");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("StatScene");
    }

    public void Scene3()
    {
        SceneManager.LoadScene("CombatScene");
    }
}