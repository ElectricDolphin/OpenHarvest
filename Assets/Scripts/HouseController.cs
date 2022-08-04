﻿using UnityEngine;

public class HouseController : MonoBehaviour
{
    public GameObject house;
    public GameObject houseExpansionFirstFloor;

    public string houseExpansionFirstFloorId = "HouseExpansionSecondFloor";

    void Start()
    {
        if (GameState.isUnlocked(houseExpansionFirstFloorId))
        {
            house.SetActive(false);
            houseExpansionFirstFloor.SetActive(true);
        }
    }
}
