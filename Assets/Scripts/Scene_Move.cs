using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Move : MonoBehaviour
{
    public string ChgScene;
    [SerializeField] private GameObject obj;

    public void OnClick()
    {
        obj.SetActive(true);
        Invoke(nameof(SceneChg), 1.0f);
    }

    public void SceneChg()
    {
        SceneManager.LoadScene(ChgScene);
    }

    public void ExtiGame()
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
