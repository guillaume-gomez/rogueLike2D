﻿/*using UnityEngine;
using System;
using System.Collections;       //Allows us to use Lists.
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour
{
    [Serializable]
    public class Count
    {
        public int minimum;
        public int maximum;

        Count(int min, int max)
        {
            minimum = min;
            maximum = max;
        }
    }

    public int columns = 8;
    public int rows = 8;
    public Count wallCount = new Count(5, 9);
    public Count foodCount = new Count(1, 5);
    public GameObject exit;
    public GameObject[] floorTiles;
    public GameObject[] wallTiles;
    public GameObject[] foodTiles;
    public GameObject[] enemyTiles;
    public GameObject[] outerWallTiles;

    private Transform boardHolder;
    private List<Vector3>  gridPositions = new List<Vector3>;

    void InitialiseList()
    {
        gridPositions.Clear();
        
        for(int x = 1; x < columns - 1; ++x)
        {
            for(int y = 1; y < rows - 1; ++y)
            {
                gridPositions.Add(new Vector3(x, y, 0f));
            }
        }
    }

    void BoardSetup()
    {
        boardHolder = new GameObject("Board").transform;

        for(int x = -1; x < columns + 1; ++x) 
        {
            for(int y = -1; y < rows - 1; ++y)
            {
                GameObject toInstanciate = floorTiles[Random.Range(0, floorTiles.length)];
                if(x == -1 || x == columns || y == -1 || y == row)
                {
                    toInstanciate = outerWallTiles[Random.Range(0, outerWallTiles.length)];
                }
                GameObject instance = Instanciate(toInstanciate, new Vector3(x, y, 0f), Quaternion.Identity) as GameObject;
                instance.transform.SetParent(boardHolder);
            }
        }
    }

    Vector3 RandomPosition()
    {
        int randomIndex = Random.Range(0, gridPositions.Count);
        Vector3 randomPosition = gridPositions[randomIndex];
        gridPositions.removeAt(randomIndex);
        return randomPosition;
    }

    void LayoutObjectAtRandom(GameObject[] tileArray, int minimum, int maximum)
    {
        int ObjectCount = Random.Range(minimum, maximum + 1);

        for(int i = 0; i < ObjectCount; ++i)
        {
            Vector3 randomPosition  = RandomPosition();
            GameObject tileChoice = tileArray[Random.Range(0, tileArray.length)];
            Instanciate (tileChoice, randomPosition, Quaternion.Identity);
        }
    }

    public void SetupScene(int level)
    {
        BoardSetup();
        InitialiseList();
        LayoutObjectAtRandom(wallTiles, wallCount.minimum, wallCount.maximum);
        LayoutObjectAtRandom(foodTiles, foodCount.minimum, foodCount.maximum);
        int enemyCount = (int)Mathf.Log(level, 2f);
        LayoutObjectAtRandom(enemyTiles, enemyCount.minimum, enemyCount.maximum);
        Instanciate(exit, new Vector3(columns -1, rows - 1, 0f), Quaternion.Identity);
    }
}*/