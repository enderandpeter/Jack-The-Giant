using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour {
    public static SceneFader instance;

    [SerializeField]
    private GameObject fadePanel;

    [SerializeField]
    private Animator fadeAnim;

	void Awake () {
        MakeSingleteon();
    }
	
	void MakeSingleteon () {
        if (instance != null)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
	}

    public void LoadLevel(string level)
    {
        StartCoroutine(FadeInOut(level));
    }

    IEnumerator FadeInOut(string level)
    {
        fadePanel.SetActive(true);
        fadeAnim.Play("Fade In");
        yield return StartCoroutine(MyCoroutine.WaitForRealSeconds(1f));
        SceneManager.LoadScene(level);
        fadeAnim.Play("Fade Out");
        yield return StartCoroutine(MyCoroutine.WaitForRealSeconds(.7f));
        fadePanel.SetActive(false);
    }
}
