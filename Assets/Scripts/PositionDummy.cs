using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PositionDummy : MonoBehaviour
{

    [SerializeField] GameObject dummyPrefab;
    [SerializeField] GameObject billPrefab;
    private GameObject[] sittingPositions;
    private GameObject dummy;
    private Animator dummyAnimator;
    //private bool startMoving = false;
    private CharacterController dummyCC;
    private GameObject bill;

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

        dummyCC = dummy.GetComponent<CharacterController>();

        //Thumbs up
        dummyAnimator = dummy.GetComponent<Animator>();
        StartCoroutine(CompleteOrder());
    }

    IEnumerator CompleteOrder()
    {
        yield return new WaitForSeconds(7f);
        dummyAnimator.SetTrigger("Completed");
        StartCoroutine(DummyPayment());
    }

    IEnumerator DummyPayment()
    {
        bill = Instantiate(billPrefab, dummy.transform.parent.position + new Vector3(0f, 1.6f, 0f), Quaternion.identity);
        bill.transform.parent = dummy.transform.parent;

        bill.transform.localScale = new Vector3(20f, 20f, 20f);

        yield return new WaitForSeconds(3.833f);
        Destroy(dummy);
    }

    /*void Update()
    {
        if(startMoving){
            Move();
        }
    }

    void Move()
    {
        Vector3 _forward = dummy.transform.TransformDirection(Vector3.forward);
        dummyCC.SimpleMove(_forward * 3);
    }*/
}
