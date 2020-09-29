using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    // configuration parameters

    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;

	// Update is called once per frame
	void Update () {

        float mousePositionInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        paddlePos.x = Mathf.Clamp(mousePositionInUnits, minX, maxX);

        transform.position = paddlePos;

    }
}
