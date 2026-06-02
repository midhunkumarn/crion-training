using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeMenue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void BackMenue()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
