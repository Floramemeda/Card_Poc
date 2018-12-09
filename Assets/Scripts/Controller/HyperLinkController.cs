using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HyperLinkController : MonoBehaviour {

    private Sprite cardDeck;


	// Use this for initialization
	public void SceneHyperlink (string sceneName) {
        SceneManager.LoadScene(sceneName);
		
	}

}
