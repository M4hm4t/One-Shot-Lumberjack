using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTrees : MonoBehaviour
{
    public int treeCount = 6;
    public Transform parent;

    void Start()
    {
        int randomChild = Random.Range(0, treeCount); // random sayýmýzý ürettik
        GameObject tree = Resources.Load<GameObject>($"Trees/Trees{randomChild}");// random aðacýmýzý resources tan çektik
        Instantiate(tree, parent);
    }
}


