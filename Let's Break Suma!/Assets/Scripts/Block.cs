using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    // paramaters
    [SerializeField] AudioClip breakSound;

    // cached references
    Levels level;
    GameStatus gameStatus;

    private void Start()
    {
        level = FindObjectOfType<Levels>();
        level.CountBreakableBlocks();
    }

    private void DestroyBlock()
    {
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.CountDestroyedBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }
}
