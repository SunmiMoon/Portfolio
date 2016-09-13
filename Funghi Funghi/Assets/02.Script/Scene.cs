using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Scene : MonoBehaviour
{

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnButtonClicked(int SelectIndex)
    {
        SceneManager.LoadScene(SelectIndex);
    }
}
