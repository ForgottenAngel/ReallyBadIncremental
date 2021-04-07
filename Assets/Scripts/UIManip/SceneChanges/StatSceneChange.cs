using UnityEngine;
using UnityEngine.SceneManagement;

public class StatSceneChange : MonoBehaviour
{
 public void NextScene()
    {
        SceneManager.LoadScene("StatScene");
    }
}
