using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public IsGen1 win;
    public IsGen1 gameOver;
    public GameObject WhiteFade;
    public string sceneToLoad;

    void Start()
    {
        win.isGen1 = false;
        gameOver.isGen1 = false;
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (this.gameObject.tag == "Exit")
            win.isGen1 = true;
        if (other.gameObject.tag == "Player")
        {
            gameOver.isGen1 = true;
            StartCoroutine(FadeCo());
        }
    }

    public IEnumerator FadeCo() {
        gameOver.isGen1 = false;
        if (WhiteFade != null)
        {
            Instantiate(WhiteFade, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(1f);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        while (!asyncOperation.isDone)
        {
            yield return null;
        }
    }
}
