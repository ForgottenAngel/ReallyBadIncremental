using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class InvSceneChange : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("InvScene");
    }
}
