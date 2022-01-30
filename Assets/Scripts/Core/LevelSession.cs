using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSession : MonoBehaviour
{
    public Vector2 CharacterPosition
    {
        get
        {
            GameSession gameSession = FindObjectOfType<GameSession>();
            return gameSession.CharacterPosition;
        }
        set
        {
            GameSession gameSession = FindObjectOfType<GameSession>();
            gameSession.CharacterPosition = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }
}
