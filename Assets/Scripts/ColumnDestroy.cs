using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Column")
        {
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "ColumnBlock")
        {
            Destroy(col.gameObject);
        }
    }
}
