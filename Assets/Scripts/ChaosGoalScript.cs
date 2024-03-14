using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    public bool isSolved = false;
    private void OnTriggerEnter(Collider col)
    {
        GameObject colObj = col.gameObject;
        if (colObj.tag == gameObject.tag)
        {
            isSolved = true;
            Destroy(colObj);
        }
    }
}
