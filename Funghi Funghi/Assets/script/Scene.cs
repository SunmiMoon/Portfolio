/*
 * FileName : Scene.cs
 * Report : 씬의 전환 및 Map로드
 * Programmer : Moon's
 * Date : 16.09.09
 */
 
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnButtonClicked(int SelectIndex)
    {
        SceneManager.LoadScene(SelectIndex);
    }
}