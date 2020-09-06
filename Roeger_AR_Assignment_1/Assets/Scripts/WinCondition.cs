using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public Material targetMat;
    private List<Collider> currentCollisions;
    public Text winText;
    public bool isCollided;

    public void Start()
    {
        currentCollisions = new List<Collider>();
        isCollided = false;
    }

    public void Update()
    {
        StartCoroutine(CheckImpact());
    }

    // Throw in some win conditions for when our target block hits the ground
    private void OnTriggerEnter(Collider other)
    {

        if (!currentCollisions.Contains(other))
        {
            currentCollisions.Add(other);
        }
    }

    private IEnumerator CheckImpact()
    {
        yield return new WaitForSeconds(10f);

        for (int i = 0; i < currentCollisions.Count; i++)
        {
            if (currentCollisions[i].GetComponent<MeshRenderer>().material == targetMat)
                isCollided = true;
        }

        if (isCollided)
            winText.text = "Nice shot!";
        else
            winText.text = "So close...";

        yield return null;
    }

}
