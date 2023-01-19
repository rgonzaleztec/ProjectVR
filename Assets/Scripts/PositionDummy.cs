using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PositionDummy : MonoBehaviour
{

    [SerializeField] GameObject dummyPrefab;
    private GameObject[] sittingPositions;
    private GameObject dummy;

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        sittingPositions = GameObject.FindGameObjectsWithTag("SittingPoint");
        int num = random.Next(sittingPositions.Length);

        dummy = Instantiate(dummyPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
        dummy.transform.parent = sittingPositions[num].transform.parent;

        dummy.transform.position = sittingPositions[num].transform.position;
        dummy.transform.rotation = sittingPositions[num].transform.rotation;
    }
}
