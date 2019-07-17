using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 0.5f;
    Transform playerTf;
    Vector3 playerPos;

    void Awake () {
        playerTf = transform;
    }

    void Start () {
        playerPos = playerTf.position;
    }

    void FixedUpdate () {
        playerPos.x += speed;
        playerTf.position = playerPos;
    }
}