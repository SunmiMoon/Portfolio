using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnBackButtonClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void OnServiveButtonClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void OnGameStartButtonClicked()
    {
        SceneManager.LoadScene(2);
    }
}
