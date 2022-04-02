using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text treeCountText; 
    public int treeCount=0;

    public void AddTree()
    {
        treeCount++;
        treeCountText.text =treeCount.ToString();
    }
}
