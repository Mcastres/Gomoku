﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GomokuBuffer;

public class stone : MonoBehaviour
{
    private MeshRenderer meshRend;
    private Collider gravity;
    private Renderer rend;
    private GomokuBuffer.Node node;

    private bool isCreate;

    public void initNode(ref GomokuBuffer.Node n) { node = n; }
    void Start() {
        rend = GetComponent<Renderer>();
        meshRend = GetComponent<MeshRenderer>();
        gravity = GetComponent<Collider>();
    }

    void OnMouseDown() {
        if (!isCreate) {
            rend.material = goban.GM.getCurrentMaterial();
            node.Player = goban.GM.getplayerTurn();
            goban.GM.nextPlayer();
            meshRend.enabled = true;
            isCreate = true;
            gravity.attachedRigidbody.useGravity = true;
        }
    }
    void OnMouseEnter() {
        if (!isCreate) {
            rend.material = goban.GM.getCurrentMaterial();
            meshRend.enabled = true;
        }
    }

    void OnMouseExit() {
        if (!isCreate) {
            meshRend.enabled = false;
        }
    }
}
