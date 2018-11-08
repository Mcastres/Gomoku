﻿using UnityEngine;
using UnityEngine.UI;
using Grpc.Core;
using GrpcBuffer;
using System;
public class gameMaster : MonoBehaviour
{
    private int playerTurn;
    private Material materialCurrentPlayer;
    public Material player1;
    public Material player2;
    private string host;
    private Channel ch;
    private DefaultCallInvoker invoker;

    void Start() {
        playerTurn = 1;
        materialCurrentPlayer = player1;
        ch = new Channel(host, port, ChannelCredentials.Insecure);
        invoker = new DefaultCallInvoker(ch);
    }

    public void nextPlayer() {
        if (playerTurn == 1) {
            playerTurn = 2;
            materialCurrentPlayer = player2;
        } else {
            playerTurn = 1;
            materialCurrentPlayer = player1;
        }
    }

    public int getplayerTurn() { return playerTurn; }
    public Material getCurrentMaterial() { return materialCurrentPlayer; }

}