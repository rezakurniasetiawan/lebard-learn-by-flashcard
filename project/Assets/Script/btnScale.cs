using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnScale : MonoBehaviour
{
     public void scele(float scele)
    {
        transform.localScale = new Vector2(1 / scele, 1 * scele);
    }
}
