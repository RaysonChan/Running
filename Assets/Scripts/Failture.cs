using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Failture : MonoBehaviour {

    public GameObject Failure; //游戏失败UI对象
    public Button Failure_return; //游戏失败UI对象返回按钮return
    public Button Failure_continue; //游戏失败UI对象进入下一关卡按钮continue

    // Use this for initialization
    void Start () {
        //添加按钮监听
        Failure_return.onClick.AddListener(OnFRClick);
        Failure_continue.onClick.AddListener(OnFCClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnFRClick()
    {
        Debug.Log("OnFRClick");
        Failure.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
    void OnFCClick()
    {
        Debug.Log("OnFCClick");
        Failure.SetActive(false);
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }
}
