using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderWithParameter : MonoBehaviour
{
    public void LoadNextScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
