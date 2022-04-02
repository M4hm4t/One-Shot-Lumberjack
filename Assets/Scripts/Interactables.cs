using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{

    public bool interactable = false;
    private AudioSource audioSource;

    public void Start()
    {
        

    }



    public void Interact()
    {
        
        Invoke("PlayTreeSound", 0.7f);
        Invoke("DestroyTree", 1);


    }

    public void PlayTreeSound ()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        AudioClip treeSound = Resources.Load<AudioClip>($"Sound/WoodSound");
        audioSource.clip = treeSound;
        audioSource.Play();
    }


    public void DestroyTree()
    {
        FindObjectOfType<GameManager>().AddTree();
        GameObject treeVFX = Resources.Load<GameObject>($"TreeVFX/TreeVFX");
        var vfx = Instantiate(treeVFX);
        vfx.transform.position = transform.position;
        
        Destroy(vfx, 1);
        Destroy(gameObject);
    }

    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            interactable = true;
            Interact();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactable = false;
        }
    }
}

