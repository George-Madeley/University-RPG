using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] Vector2 characterStartingPosition;

    private Vector2 _characterPosition;
    public Vector2 CharacterPosition
    {
        get
        {
            return _characterPosition;
        }
        set
        {
            _characterPosition = value;
        }
    }

    private void Awake()
    {
        DestroyOtherGameSessions();
    }

    private void Start()
    {
        _characterPosition = characterStartingPosition;
    }

    private void DestroyOtherGameSessions()
    {
        int numberOfGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberOfGameSessions > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
