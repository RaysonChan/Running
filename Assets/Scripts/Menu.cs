using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button start_btn;

    void Start()
    {
        start_btn.onClick.AddListener(OnStartBtnClick);
    }

    void OnStartBtnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
