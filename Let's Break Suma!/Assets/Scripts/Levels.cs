using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour {

    // Serialized parameters for debugging
    [SerializeField] int breakableBlocks;

    // cached reference

    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();    
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void CountDestroyedBlocks()
    {
        breakableBlocks--;

        if(breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }

}
