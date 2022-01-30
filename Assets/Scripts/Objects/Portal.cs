using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    [SerializeField] float levelExitDelay = 2f;
    [SerializeField] float levelExitSlowMoFactor = 1f;
    [SerializeField] string sceneToLoad;
    [SerializeField] Vector2 locationOfCharacter = new Vector2(0, 0);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SetCharacterPosition();
        StartCoroutine(LoadNextLevel());
    }

    private void SetCharacterPosition()
    {
        LevelSession levelSession = FindObjectOfType<LevelSession>();
        levelSession.CharacterPosition = locationOfCharacter;
    }

    IEnumerator LoadNextLevel()
    {
        Time.timeScale = levelExitSlowMoFactor;
        yield return new WaitForSecondsRealtime(levelExitDelay);
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToLoad);
    }

    // Start is called before the first frame update

}
